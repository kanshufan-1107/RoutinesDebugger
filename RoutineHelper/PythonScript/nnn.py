import os
import time
import numpy as np
import sys
from utils import Bar, AverageMeter, dotdict

import torch
import torch.optim as optim
from torch.autograd import Variable

from dqn import DQN as nnet

args = dotdict({
    'lr': 0.005,
    'dropout': 0.3,
    'epochs': 5,
    'batch_size': 1,
    'cuda': True,
    'num_channels': 512,
})


class NNetWrapper:
    def __init__(self):
        self.nnet = nnet(args)

        if args.cuda:
            self.nnet.cuda()

    def train(self, examples):
        """
        examples: list of examples, each example is of form (state, pi, v)
        """
        optimizer = optim.Adam(self.nnet.parameters())

        for epoch in range(args.epochs):
            # print('EPOCH ::: ' + str(epoch+1))
            self.nnet.train()
            data_time = AverageMeter()
            batch_time = AverageMeter()
            v_losses = AverageMeter()
            end = time.time()

            bar = Bar('Training Net', max=int(len(examples)/args.batch_size))
            batch_idx = 0

            while batch_idx < int(len(examples)/args.batch_size):
                sample_ids = np.random.randint(len(examples), size=args.batch_size)
                states, vs = list(zip(*[examples[i] for i in sample_ids]))
                states = torch.FloatTensor(np.array(states).astype(np.float64)).unsqueeze(1)
                target_vs = torch.FloatTensor(np.array(vs).astype(np.float64))

                # predict
                if args.cuda:
                    states, target_vs = states.contiguous().cuda(), target_vs.contiguous().cuda()
                states, target_vs = Variable(states), Variable(target_vs)

                # measure data loading time
                data_time.update(time.time() - end)

                # compute output
                out_v = self.nnet(states)
                l_v = self.loss_v(target_vs, out_v)
                total_loss = l_v

                # record loss
                v_losses.update(l_v.data, states.size(0))

                # compute gradient and do SGD step
                optimizer.zero_grad()
                total_loss.backward()
                optimizer.step()

                # measure elapsed time
                batch_time.update(time.time() - end)
                end = time.time()
                batch_idx += 1

                # plot progress
                bar.suffix  = '({batch}/{size}) Data: {data:.3f}s | Batch: {bt:.3f}s | Total: {total:} | ETA: {eta:} | Loss_v: {lv:.3f}'.format(
                            batch=batch_idx,
                            size=int(len(examples)/args.batch_size),
                            data=data_time.avg,
                            bt=batch_time.avg,
                            total=bar.elapsed_td,
                            eta=bar.eta_td,
                            lv=v_losses.avg,
                            )
                bar.next()
            bar.finish()


    def predict(self, state):
        """
        state: np array with state
        """
        # timing
        start = time.time()

        # preparing input
        state = torch.FloatTensor(state.astype(np.float64)).unsqueeze(0).unsqueeze(0)
        if args.cuda: state = state.contiguous().cuda()
        self.nnet.eval()
        with torch.no_grad():
            state = Variable(state)
            # state = state.view(1, self.board_x, self.board_y)


            v = self.nnet(state)

            print('PREDICTION TIME TAKEN : {0:03f}'.format(time.time()-start))
            return v.data.cpu().numpy()

    def loss_v(self, targets, outputs):
        return torch.sum((targets-outputs.view(-1))**2)/targets.size()[0]

    def save_checkpoint(self, folder='checkpoint', filename='checkpoint.pth.tar'):
        filepath = os.path.join(folder, filename)
        if not os.path.exists(folder):
            print("Checkpoint Directory does not exist! Making directory {}".format(folder))
            os.mkdir(folder)
        torch.save({
            'state_dict' : self.nnet.state_dict(),
        }, filepath)

    def load_checkpoint(self, folder='checkpoint', filename='checkpoint.pth.tar'):
        # https://github.com/pytorch/examples/blob/master/imagenet/main.py#L98
        filepath = os.path.join(folder, filename)
        if not os.path.exists(filepath):
            raise("No model in path {}".format(filepath))
        checkpoint = torch.load(filepath)
        self.nnet.load_state_dict(checkpoint['state_dict'])

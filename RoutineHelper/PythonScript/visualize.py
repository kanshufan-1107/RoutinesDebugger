import torch
from dqn import DQN
from utils import Bar, AverageMeter, dotdict


args = dotdict({
    'lr': 0.005,
    'dropout': 0.3,
    'epochs': 5,
    'batch_size': 1,
    'cuda': True,
    'num_channels': 512,
})

if __name__ == '__main__':
    dqn = DQN(args)
    input_names = ['Feature Vector']
    output_names = ['Playfield Score']
    torch.onnx.export(dqn, torch.zeros([1, 1, 2511])
    , 'dqn.onnx', input_names=input_names, output_names=output_names)

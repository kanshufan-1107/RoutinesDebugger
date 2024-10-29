import sys
import torch
import torch.nn as nn
import torch.nn.functional as F

class BasicBlock(nn.Module):
    def __init__(self, ni, nf):
        super(BasicBlock, self).__init__()
        self.conv = nn.Conv1d(ni, nf, kernel_size=3)
        self.bn = nn.BatchNorm1d(nf, track_running_stats=False)

    def forward(self, x):
        x = F.relu(self.bn(self.conv(x)))
        return x


class ResBlock(nn.Module):
    def __init__(self, ni, nf, kernel_size=3):
        super(ResBlock, self).__init__()

        self.conv1 = nn.Conv1d(nf, nf,
                               kernel_size=kernel_size, padding=1)
        self.conv2 = nn.Conv1d(nf, nf,
                               kernel_size=kernel_size, padding=1)

        self.bn1 = nn.BatchNorm1d(nf, track_running_stats=False)
        self.bn2 = nn.BatchNorm1d(nf, track_running_stats=False)

    def forward(self, x):
        residual = x
        x = F.relu(self.bn1(self.conv1(x)))
        x = F.relu(self.bn2(self.conv2(residual + x)))
        return x


class DQN(nn.Module):
    def __init__(self, args):
        self.layers = [16, 32, 64, 128, 256]
        self.state_size = 2511
        self.args = args

        super().__init__()
        # first conv layer (input as state, feed into res layers)
        self.convx = nn.Conv1d(1, 16,  # append last three turns onto input as 3rd dim
                               kernel_size=3, padding=1)
        self.bnx = nn.BatchNorm1d(16, track_running_stats=False)

        # residual layers (10)
        self.layers1 = nn.ModuleList([BasicBlock(self.layers[i], self.layers[i + 1])
                                      for i in range(len(self.layers) - 1)])
        self.layers2 = nn.ModuleList([ResBlock(self.layers[i + 1], self.layers[i + 1])
                                      for i in range(len(self.layers) - 1)])
        self.layers3 = nn.ModuleList([ResBlock(self.layers[i + 1], self.layers[i + 1])
                                      for i in range(len(self.layers) - 1)])

        # value head (output as state value [-1,1])
        self.v_conv1 = nn.Conv1d(256, 4, kernel_size=4)
        self.v_bn1 = nn.BatchNorm1d(4, track_running_stats=False)
        self.v_fc1 = nn.Linear(self.args.batch_size * 10000, 64)
        self.v_fc2 = nn.Linear(64, self.args.batch_size)

    def forward(self, state_input):
        # train conv layer --> feed into res layers,
        # pass into action and value seperately and return
        x = F.relu(self.bnx(self.convx(state_input)))  # convlayer of state into bn into relu
        for l1, l2, l3 in zip(self.layers1, self.layers2, self.layers3):
            x = l3(l2(l1(x)))  # conv into bn into relu(orig + conv into bn) into each layer batch

        # value head (score of board state)
        v = F.relu(self.v_bn1(self.v_conv1(x)))  # feed resnet into value head
        v = v.view(-1, self.args.batch_size * 10000)
        v = F.relu(self.v_fc1(v))
        #v = F.tanh(self.v_fc2(v))
        v = self.v_fc2(v)
        return v
from nnn import NNetWrapper as nn
from utils import dotdict
import sys, os, time
from pickle import Pickler, Unpickler
from random import shuffle
from utils import Bar, AverageMeter, dotdict
from gensim.models.word2vec import LineSentence
from gensim.models.doc2vec import Doc2Vec, TaggedDocument
import json
import numpy
import jieba

args = dotdict({
    'numIters': 100,
    'numEps': 100,
    'tempThreshold': 15,
    'updateThreshold': 0.6,
    'cpuct': 10,

    'checkpoint': './temp/',
    'load_model': False,
    'load_folder_file': ('./temp/','temp.pth.tar'),
    'numItersForTrainExamplesHistory': 20,
})

trainExamplesHistory = []


def saveTrainExamples():
    if not os.path.exists(args.load_folder_file[0]):
        os.mkdir(args.load_folder_file[0])
    modelFile = os.path.join(args.load_folder_file[0], args.load_folder_file[1])
    examplesFile = modelFile + ".examples"
    with open(examplesFile, "wb+") as f:
        Pickler(f).dump(trainExamplesHistory)


def loadTrainExamples():
    modelFile = os.path.join(args.load_folder_file[0], args.load_folder_file[1])
    examplesFile = modelFile + ".examples"
    if not os.path.isfile(examplesFile):
        print(examplesFile)
        r = input("File with trainExamples not found. Continue? [y|n]")
        if r != "y":
            sys.exit()
    else:
        print("File with trainExamples found. Read it.")
        with open(examplesFile, "rb") as f:
            trainExamplesHistory = Unpickler(f).load()
            return trainExamplesHistory


def convertTrainExamples():
    model = Doc2Vec.load("doc2vec.model")
    with open('SerializedResult.txt', 'r', encoding="utf-8") as source:
        l = source.readlines()
        bar = Bar('Converting Data', max=int(len(l)))
        for line in l:
            line = line.strip().split(",")
            for index, item in enumerate(line):
                try:
                    line[index] = float(item)
                except Exception:
                    for pos, value in enumerate(model.infer_vector(list(jieba.cut(item, cut_all=False)))):
                        if pos == 0:
                            line[index] = value
                        else:
                            line.insert(pos + index, value)
            trainExamplesHistory.append([line[:-1], line[-1]])
            bar.next()
        bar.finish()


if __name__ == '__main__':
    nnet = nn()

    if args.load_model:
        nnet.load_checkpoint(args.load_folder_file[0], args.load_folder_file[1])

    trainExamplesHistory = loadTrainExamples()
    shuffle(trainExamplesHistory)

    for i in range(1, args.numIters + 1):
        # bookkeeping
        print('------ ITER ' + str(i) + ' ------')
        # examples of the iteration

        nnet.train(trainExamplesHistory)

        nnet.save_checkpoint(folder=args.load_folder_file[0], filename=args.load_folder_file[1])

from pickle import Pickler, Unpickler
from random import shuffle
from utils import Bar, AverageMeter, dotdict
from gensim.models.doc2vec import Doc2Vec, TaggedDocument
import os, sys
import jieba

args = dotdict({
    'checkpoint': './temp/',
    'load_folder_file': ('./temp/','temp.pth.tar')
})

trainExamplesHistory = []


def saveTrainExamples():
    if not os.path.exists(args.load_folder_file[0]):
        os.mkdir(args.load_folder_file[0])
    modelFile = os.path.join(args.load_folder_file[0], args.load_folder_file[1])
    examplesFile = modelFile + ".examples"
    with open(examplesFile, "wb+") as f:
        Pickler(f).dump(trainExamplesHistory)


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
    convertTrainExamples()
    for item in reversed(trainExamplesHistory):
        if item[1] < -1000 or item[1] > 1000:
            print("removed")
            trainExamplesHistory.remove(item)
        else:
            print("continue")
    saveTrainExamples()

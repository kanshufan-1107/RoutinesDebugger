# coding:utf-8

from nnn import NNetWrapper as nn
import numpy
from utils import Bar, AverageMeter, dotdict
from gensim.models.doc2vec import Doc2Vec, TaggedDocument
import jieba

args = dotdict({
    'checkpoint': './temp/',
    'load_model': True,
    'load_folder_file': ('./temp/', 'temp.pth.tar')
})

if __name__ == '__main__':
    nnet = nn()

    if args.load_model:
        nnet.load_checkpoint(args.load_folder_file[0], args.load_folder_file[1])

    model = Doc2Vec.load("doc2vec.model")

    while True:
        line = input("Input encoding:\n")
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
        line = numpy.array(line)
        print(nnet.predict(line))

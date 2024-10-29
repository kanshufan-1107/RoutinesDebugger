from gensim.models.word2vec import LineSentence
from gensim.models.doc2vec import Doc2Vec, TaggedDocument
import json
import numpy
import jieba

t = "<b>战吼：</b>随机将一张圣骑士牌置入你的手牌。"
model = Doc2Vec.load("doc2vec.model")
a = numpy.array(model.infer_vector(list(jieba.cut(t, cut_all=False))))

with open('SerializedCard.txt', "r", encoding="utf-8") as source:
    l = source.readlines()
    for t in model.docvecs.most_similar([a], topn=10):
        print("{} {} {}".format(l[t[0]].replace("\n", ""), t[0], t[1]))

print(a)
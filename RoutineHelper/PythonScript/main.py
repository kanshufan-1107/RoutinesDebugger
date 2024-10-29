from gensim.models.word2vec import LineSentence
from gensim.models.doc2vec import Doc2Vec, TaggedDocument
import json
import jieba


def build_w2v(filename):
    with open(filename, "r", encoding="utf-8") as source:
        documents = [TaggedDocument(list(jieba.cut(doc, cut_all=False)), [i]) for i, doc in enumerate(source.readlines())]
    model = Doc2Vec(documents, min_count=10, vector_size=20, epochs=80, workers=16)
    print(model.infer_vector(['战吼']))
    model.save("doc2vec.model")


build_w2v('SerializedCard.txt')

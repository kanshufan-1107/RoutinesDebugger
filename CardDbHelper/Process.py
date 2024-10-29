from xml.dom.minidom import parse
import xml.dom.minidom
import os

WriteFile = False
TargetDir = "BattleGroundsCardSims"
if not os.path.exists(TargetDir):
    os.mkdir(TargetDir)

BattleGroundsCardDefsTree = xml.dom.minidom.parse("BattleGroundsCardDefs.xml")
BattleGroundsCardDefs = BattleGroundsCardDefsTree.documentElement

BattleGroundsEntities = BattleGroundsCardDefs.getElementsByTagName("Entity")

AllCardDefsTree = xml.dom.minidom.parse("AllCardDefs.xml")
AllCardDefs = AllCardDefsTree.documentElement

AllCardDefsEntities = AllCardDefs.getElementsByTagName("Entity")

for index, entity in enumerate(BattleGroundsEntities):
    ID = entity.getAttribute("ID")
    CardID = entity.getAttribute("CardID")
    Tags = entity.getElementsByTagName("Tag")
    zhCN = Tags[0].getElementsByTagName("zhCN")[0].childNodes[0].data
    Break = False 
    Found = False
    for reference in AllCardDefsEntities:
        rCardID = reference.getAttribute("CardID")
        rTags = reference.getElementsByTagName("Tag")
        rzhCN = rTags[0].getElementsByTagName("zhCN")[0].childNodes[0].data
        if rzhCN == zhCN and CardID != rCardID:
            Found = True
            print("Found Match {} => {}".format(CardID, rCardID))
            rPlayRequirement = reference.getElementsByTagName("PlayRequirement")
            for req in rPlayRequirement:
                BattleGroundsEntities[index].appendChild(req)
            if WriteFile:
                File = ""
                Content = ""
                FileName = "Sim_{}.cs".format(rCardID)
                NewFileName = "Sim_{}.cs".format(CardID)
                for dirpath, dirnames, filenames in os.walk("CardSims"):
                    for filename in filenames:
                        if filename == FileName:
                            File = os.path.join(dirpath, filename)
                if File != "":
                    with open(File, "r") as s:
                        Content = "\n".join(s.readlines())
                    with open(os.path.join(TargetDir, NewFileName), "w") as t:
                        t.write(Content.replace(rCardID, CardID))
                    print("Write {} => {} Success.".format(FileName, NewFileName))
                else:
                    print("However cs Not Found.")
    if not Found:
        print("Match Not Found for {}: {}".format(CardID, zhCN))

try:
    with open('ResultCardDefs.xml','w',encoding='UTF-8') as fh:
        BattleGroundsCardDefsTree.writexml(fh,indent='    ',addindent='',newl='\n')
        print('Write File Complete.')
except Exception as err:
    print('{err}'.format(err=err))

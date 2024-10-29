from xml.dom.minidom import parse
import xml.dom.minidom
import os

BattleGroundsCardDefsTree = xml.dom.minidom.parse("FreshCardDefs.xml")
BattleGroundsCardDefs = BattleGroundsCardDefsTree.documentElement

BattleGroundsEntities = BattleGroundsCardDefs.getElementsByTagName("Entity")

AllCardDefsTree = xml.dom.minidom.parse("AllCardDefs.xml")
AllCardDefs = AllCardDefsTree.documentElement

AllCardDefsEntities = AllCardDefs.getElementsByTagName("Entity")
AllCardDefsEntitiesList = []


for index, entity in enumerate(AllCardDefsEntities):
    CardID = entity.getAttribute("CardID")
    AllCardDefsEntitiesList.append(CardID)
    print(index)

print(len(AllCardDefsEntitiesList))
print()

for index, entity in enumerate(BattleGroundsEntities):
    ID = entity.getAttribute("ID")
    CardID = entity.getAttribute("CardID")
    Tags = entity.getElementsByTagName("Tag")
    zhCN = Tags[0].getElementsByTagName("zhCN")[0].childNodes[0].data
    if CardID not in AllCardDefsEntitiesList:
        print("Added " + zhCN + " " + CardID)
        AllCardDefs.appendChild(entity)

try:
    with open('ResultCardDefs.xml','w',encoding='UTF-8') as fh:
        AllCardDefsTree.writexml(fh,indent='\t',addindent='\t',newl='\n')
        print('Write File Complete.')
except Exception as err:
    print('{err}'.format(err=err))

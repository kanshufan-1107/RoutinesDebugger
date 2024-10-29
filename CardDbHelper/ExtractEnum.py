from xml.dom.minidom import parse
import xml.dom.minidom
import os

BattleGroundsCardDefsTree = xml.dom.minidom.parse("CardDefs.xml")
BattleGroundsCardDefs = BattleGroundsCardDefsTree.documentElement

BattleGroundsEntities = BattleGroundsCardDefs.getElementsByTagName("Entity")

for index, entity in enumerate(BattleGroundsEntities):
    ID = entity.getAttribute("ID")
    CardID = entity.getAttribute("CardID")
    Tags = entity.getElementsByTagName("Tag")
    TechLevel = 0
    Health = 0
    Atk = 0
    Cost = 0
    CardTextzhCN = ""
    CardTextenUS = ""
    Skip = True
    for tag in Tags:
        CardTextzhCN = ""
        CardTextenUS = ""
        TechLevel = 0
        if tag.getAttribute("enumID") == "184":
            try:
                CardTextzhCN = tag.getElementsByTagName("zhCN")[0].childNodes[0].data
                CardTextenUS = tag.getElementsByTagName("enUS")[0].childNodes[0].data
            except:
                pass
        if tag.getAttribute("enumID") == "1440":
            TechLevel = tag.getAttribute("value")
        if tag.getAttribute("enumID") == "45":
            Health = tag.getAttribute("value")
        if tag.getAttribute("enumID") == "47":
            Atk = tag.getAttribute("value")
        if tag.getAttribute("enumID") == "48":
            Cost = tag.getAttribute("value")
    if not CardID.startswith("RLK"):
        continue
    try:
        zhCN = Tags[0].getElementsByTagName("zhCN")[0].childNodes[0].data
        enUS = Tags[0].getElementsByTagName("enUS")[0].childNodes[0].data
    except:
        continue
    # print("""            /// <summary>
    #         /// <para>巫妖王的进军 费用：{} 攻击力：{} 生命值：{}</para>
    #         /// <para>{}</para>
    #         /// <para>{}</para>
    #         /// <para>{}</para>
    #         /// <para>{}</para>
    #         /// </summary>""".format(Cost, Atk, Health, zhCN, enUS, CardTextzhCN.replace("\n", ""), CardTextenUS.replace("\n", "")))
    print("""            {} = {},""".format(CardID, ID))


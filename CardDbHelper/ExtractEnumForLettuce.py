from xml.dom.minidom import parse
import xml.dom.minidom
import os

LettuceCardDefsTree = xml.dom.minidom.parse("LettuceCardDefs.xml")
LettuceCardDefs = LettuceCardDefsTree.documentElement

LettuceEntities = LettuceCardDefs.getElementsByTagName("Entity")

for index, entity in enumerate(LettuceEntities):
    ID = entity.getAttribute("ID")
    CardID = entity.getAttribute("CardID")
    Tags = entity.getElementsByTagName("Tag")
    TechLevel = 0
    Health = 0
    Atk = 0
    Cost = 0
    for tag in Tags:
        CardTextzhCN = ""
        CardTextenUS = ""
        TechLevel = 0
        
        if tag.getAttribute("enumID") == "184":
            CardTextzhCN = tag.getElementsByTagName("zhCN")[0].childNodes[0].data
            CardTextenUS = tag.getElementsByTagName("enUS")[0].childNodes[0].data
        if tag.getAttribute("enumID") == "1666":
            Role = tag.getAttribute("value")
        if tag.getAttribute("enumID") == "45":
            Health = tag.getAttribute("value")
        if tag.getAttribute("enumID") == "47":
            Atk = tag.getAttribute("value")
        if tag.getAttribute("enumID") == "48":
            Cost = tag.getAttribute("value")
    zhCN = Tags[0].getElementsByTagName("zhCN")[0].childNodes[0].data
    enUS = Tags[0].getElementsByTagName("enUS")[0].childNodes[0].data
    print("""            /// <summary>
            /// <para>佣兵模式 角色：{} 费用：{} 攻击力：{} 生命值：{}</para>
            /// <para>{}</para>
            /// <para>{}</para>
            /// <para>{}</para>
            /// <para>{}</para>
            /// </summary>""".format(Role, Cost, Atk, Health, zhCN, enUS, CardTextzhCN.replace("\n", ""), CardTextenUS.replace("\n", "")))
    print("""            {} = {},""".format(CardID, ID))


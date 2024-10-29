from xml.dom.minidom import parse
import xml.dom.minidom
import os

LettuceCardDefsTree = xml.dom.minidom.parse("LettuceCardDefs.xml")
LettuceCardDefs = LettuceCardDefsTree.documentElement

LettuceEntities = LettuceCardDefs.getElementsByTagName("Entity")
repeat = []
for index, entity in enumerate(LettuceEntities):
    ID = entity.getAttribute("ID")
    CardID = entity.getAttribute("CardID")
    Tags = entity.getElementsByTagName("Tag")
    Role = 0
    Health = 0
    Atk = 0
    Cost = 0
    CardTextzhCN = ""
    CardTextenUS = ""
    for tag in Tags:
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
    sb = enUS
    sb = sb.replace("&lt;", "");
    sb = sb.replace("b&gt;", "");
    sb = sb.replace("/b&gt;", "");
    sb = sb.replace("&", "n")
    sb = sb.replace("'", "");
    sb = sb.replace(" ", "");
    sb = sb.replace(":", "");
    sb = sb.replace(".", "");
    sb = sb.replace("!", "");
    sb = sb.replace("?", "");
    sb = sb.replace("-", "");
    sb = sb.replace("_", "");
    sb = sb.replace(",", "");
    sb = sb.replace("(", "");
    sb = sb.replace(")", "");
    sb = sb.replace("/", "");
    sb = sb.replace("\"", "");
    sb = sb.replace("’", "");
    if sb in repeat:
        continue
    repeat.append(sb)
    print("""            /// <summary>
            /// <para>佣兵模式 角色：{} 费用：{} 攻击力：{} 生命值：{}</para>
            /// <para>{}</para>
            /// <para>{}</para>
            /// <para>{}</para>
            /// <para>{}</para>
            /// </summary>""".format(Role, Cost, Atk, Health, zhCN, enUS, CardTextzhCN.replace("\n", ""), CardTextenUS.replace("\n", "")))
    print("""            {},""".format(sb.lower()))


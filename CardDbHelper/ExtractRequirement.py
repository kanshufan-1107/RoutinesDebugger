from xml.dom.minidom import parse
import xml.dom.minidom
import os
import json

AllCardDefsTree = xml.dom.minidom.parse("AllCardDefs.xml")
AllCardDefs = AllCardDefsTree.documentElement

AllCardDefsEntities = AllCardDefs.getElementsByTagName("Entity")

output = {"Records": []}
for index, entity in enumerate(AllCardDefsEntities):
    ID = entity.getAttribute("ID")
    CardID = entity.getAttribute("CardID")
    Tags = entity.getElementsByTagName("Tag")
    zhCN = Tags[0].getElementsByTagName("zhCN")[0].childNodes[0].data
    print(CardID)
    rPlayRequirement = entity.getElementsByTagName("PlayRequirement")
    for req in rPlayRequirement:
        value = 0
        if req.getAttribute("param") != "":
            value = req.getAttribute("param")
        output["Records"].append({"CardEnum": ID, "CardID": CardID, "ReqID": req.getAttribute("reqID"), "ReqValue": value})

export = json.dumps(
    output,
    indent=4,
    ensure_ascii=False
).encode("utf8")
with open(os.path.join('.', f"Requires.json"), "wb") as f:
    f.write(export)
    print(f"Process Finished!")


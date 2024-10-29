import os
import sys
import json
import UnityPy

def unpack_card_assets_by_name(name : str, source_file : str, destination_dir : str):
    # Unpack Card Assets
    env = UnityPy.load(source_file)

    for obj in env.objects:
        if obj.type == "MonoBehaviour":
            data = obj.read()
            if data.name == name:
                print(f"Parsing {data.name}...")
                if obj.serialized_type.nodes:
                    extension = ".json"
                    export = json.dumps(
                        obj.read_typetree(),
                        indent=4,
                        ensure_ascii=False
                    ).encode("utf8")
                    with open(os.path.join(destination_dir, f"{data.name}{extension}"), "wb") as f:
                        f.write(export)
                        print(f"Parsed {data.name}!")
                    return obj.read_typetree()
    return {}

if len(sys.argv) != 3:
    print("Requiring 2 parameters, exiting.")
else:
    with open("Requires.json", "r") as f:
        card_req = json.loads("\n".join(f.readlines()))["Records"]
    card_req = sorted(card_req, key = lambda i: int(i['CardEnum']), reverse=False)
    card = unpack_card_assets_by_name("CARD", sys.argv[1], sys.argv[2])["Records"]
    card_tag = unpack_card_assets_by_name("CARD_TAG", sys.argv[1], sys.argv[2])["Records"]
    output = {"Cards": []}
    for item in card:
        rebuild = {}
        print("Converting {}".format(item["m_noteMiniGuid"]))
        rebuild["CardID"] = item["m_noteMiniGuid"]
        rebuild["CardEnum"] = item["m_ID"]
        rebuild["CardName"] = item["m_name"]["m_locValues"][0]
        rebuild["CardName_zhCN"] = item["m_name"]["m_locValues"][-2]
        rebuild["Tags"] = []
        cut = 0
        for index, tag in enumerate(card_tag):
            if tag["m_cardId"] == item["m_ID"]:
                rebuild["Tags"].append({"TagID": tag["m_tagId"], "TagValue": tag["m_tagValue"]})
                cut = index + 1
            else:
                break
        card_tag = card_tag[cut:]
        rebuild["Requires"] = []
        cut = 0
        for index, req in enumerate(card_req):
            if int(req["CardEnum"]) == int(item["m_ID"]):
                rebuild["Requires"].append({"ReqID": int(req["ReqID"]), "ReqValue": int(req["ReqValue"])})
                print("Found")
                cut = index + 1
            else:
                break
        card_req = card_req[cut:]

        output["Cards"].append(rebuild)
        # rebuild["Requires"]
    export = json.dumps(
        output,
        indent=4,
        ensure_ascii=False
    ).encode("utf8")
    with open(os.path.join(sys.argv[2], f"CardDefs.json"), "wb") as f:
        f.write(export)
        print(f"Process Finished!")


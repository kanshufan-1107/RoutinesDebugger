import os
import sys
import json
import UnityPy

def unpack_card_assets(source_file : str, destination_dir : str):
    # Unpack Card Assets
    env = UnityPy.load(source_file)

    for obj in env.objects:
        if obj.type == "MonoBehaviour":
            data = obj.read()
            if data.name in ["CARD", "CARD_TAG"]:
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

if len(sys.argv) != 3:
    print("Requiring 2 parameters, exiting.")
else:
    unpack_card_assets(sys.argv[1], sys.argv[2])

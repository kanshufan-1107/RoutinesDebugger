import os
import shutil
import re
import xml.etree.ElementTree as ET
import black
import re


def generate_csharp_file_content(card_name_cn, card_name_en, entity_id, card_description_cn, card_description_en):
    csharp_code = '''using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{{
    class Sim_{ENTITY_ID} : SimTemplate //* {CARD_NAME_CHINESE} {CARD_NAME_ENGLISH}
    {{
        // {CARD_DESCRIPTION_CHINESE}
        // {CARD_DESCRIPTION_ENGLISH}
    }}
}}'''.format(ENTITY_ID=entity_id,
             CARD_NAME_CHINESE=card_name_cn,
             CARD_NAME_ENGLISH=card_name_en,
             CARD_DESCRIPTION_CHINESE=card_description_cn,
             CARD_DESCRIPTION_ENGLISH=card_description_en)
    return format_csharp_code(csharp_code)


def format_csharp_code(code):
    # try:
    #     return black.format_str(code, mode=black.FileMode(line_length=79))
    # except Exception as e:
    #     print("Error formatting code: {}".format(str(e)))
    while "\n\n" in code:
        code = code.replace("\n\n", "\n")
    return code


def build_file_map(search_dir):
    # Build a map of all the files in the search directory
    file_map = {}
    for dirpath, dirnames, filenames in os.walk(search_dir):
        for filename in filenames:
            match = re.match(r"Sim_(.+)\.cs$", filename)
            if match is not None:
                entity_id = match.group(1)
                file_map[entity_id] = os.path.join(dirpath, filename)
    return file_map


def parse_entity_definition_xml(root):
    card_name = {}
    card_text = {}
    for tag in root.findall("./Tag"):
        name = tag.attrib["name"]
        if name == "CARDNAME":
            for child in tag:
                card_name[child.tag] = child.text
        elif name == "CARDTEXT":
            for child in tag:
                card_text[child.tag] = child.text
    return {"card_name": card_name, "card_text": card_text}


def parse_xml_file(xml_file_path, search_dir, dest_dir):
    # Build a map of all the simulation files in the search directory
    file_map = build_file_map(search_dir)

    # Load the XML file
    with open(xml_file_path) as f:
        xml = f.read()
        root = ET.fromstring("<root>" + xml + "</root>")

    if not os.path.exists(dest_dir):
        os.makedirs(dest_dir)

    # Find all the entity ID's in the XML file and process each one
    for entity_elem in root.findall(".//Entity[@CardID]"):
        card_id = entity_elem.get("CardID")
        if card_id.startswith("RLK_Prologue"):
            # Remove the "RLK_Prologue" prefix from the card ID
            entity_id = card_id.replace("RLK_Prologue_", "", 1)

            # Find the corresponding simulation file in the file map
            sim_file = file_map.get(entity_id)
            # Rename the simulation file to include the full entity ID
            new_sim_file = os.path.join(dest_dir, "Sim_{}.cs".format(card_id))

            if sim_file is None:

                definition = parse_entity_definition_xml(entity_elem)
                print("Could not find simulation file for entity ID {}".format(entity_id))
                continue
                try:
                    contents = generate_csharp_file_content(definition["card_name"]["zhCN"],
                                                            definition["card_name"]["enUS"],
                                                            card_id,
                                                            definition["card_text"]["zhCN"],
                                                            definition["card_text"]["enUS"])
                    with open(new_sim_file, "w") as f_out:
                        contents = format_csharp_code(contents)
                        f_out.write(contents)

                    print("Generated entity ID {}".format(entity_id))
                except Exception as e:
                    print("Failed to generate entity ID {}".format(entity_id))
            else:
                # Rename the class name inside the C# file to also include the full entity ID
                with open(sim_file, "r") as f_in, open(new_sim_file, "w") as f_out:
                    contents = f_in.read()
                    contents = contents.replace("class Sim_{}".format(entity_id), "class Sim_{}".format(card_id))
                    contents = format_csharp_code(contents)
                    f_out.write(contents)

                print("Processed entity ID {}".format(entity_id))


if __name__ == "__main__":
    xml_file_path = "RLKCardDefs.xml"
    search_dir = "../../HearthstoneClient/Routines/DefaultRoutine/Silverfish/cards/"
    dest_dir = "./RLKP巫妖王的进军序章"
    parse_xml_file(xml_file_path, search_dir, dest_dir)

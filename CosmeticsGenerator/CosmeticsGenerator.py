import os
import sys
import json

baseFilePath = r'K:\Borderlands 3 - Tools\Unreal Paks\-Extract'

emotes, decos, heads, skins, echos,unknown,trinkets = [],[],[],[],[],[],[]

for subdir, dirs, files in os.walk(baseFilePath):
    for file in files:
        if ".json" not in file.lower(): continue

        walkedPath = subdir + os.sep + file
        if ("customizations" not in walkedPath.lower() and "roomdecoration" not in walkedPath.lower()) or "att_" in walkedPath.lower() or "itempool" in walkedPath.lower() or "Table_CrazyEarlCustomizationCost" in walkedPath or "struct_" in walkedPath.lower() or "bpclass_" in walkedPath.lower() and "actor" not in file and "inventorysetup_emote_v2" not in file.lower() : continue

        try: 
            with open(walkedPath, encoding='utf8') as jsonFile:
                data = json.load(jsonFile)
        except:
            print("EXCEPTION: {}".format(walkedPath))
            continue

        for d in data:
            if "export_type" not in d: continue

            if d["export_type"].lower() == "customizationinventorydata" and "InventoryName" in d and "string" in d["InventoryName"] and "InventoryActorClass" in d: 
                # Emotes: BPClass_Customization_Emote_C
                # Room Deco: BPClass_Customization_RoomDecoration_C
                # Heads: BPClass_Customization_Head_C
                # Skins: BPClass_Customization_Skin_C
                # Echo Themes: BPClass_Customization_Echo_C
                actorClass = d["InventoryActorClass"][0]
                assetPath = (walkedPath.replace(baseFilePath, "").replace('OakGame','').replace(r'Content','Game').replace('\\','/').replace('//','/').replace(".json",""))
                assetPath += ("." + assetPath.split('/')[-1])

                if "default" in assetPath.lower(): continue

                if assetPath.startswith("/PatchDLC"): 
                    assetPath = "/Game" + assetPath

                print("Asset Path: {}".format(assetPath))
                if actorClass == "BPClass_Customization_Emote_C" or actorClass == "BPClass_Emote_v2_C": # Emotes
                    # Default emotes are kinda weird
                    if "01_Wave" in assetPath or "02_Cheer" in assetPath or "03_Point" in assetPath or "04_Laugh" in assetPath: continue

                    print(" Emote: {}".format(assetPath))
                    emotes += [assetPath]
                elif actorClass == "BPClass_Customization_RoomDecoration_C": # Room Deco
                    print(" Deco: {}".format(assetPath))
                    decos += [assetPath]
                elif actorClass == "BPClass_Customization_Head_C": # Heads
                    print(" Head: {}".format(assetPath))
                    heads += [assetPath]
                elif actorClass == "BPClass_Customization_Skin_C": # Skins
                    print(" Room: {}".format(assetPath))
                    skins += [assetPath]
                elif actorClass == "BPClass_Customization_Echo_C":
                    print(" Echo: {}".format(assetPath))
                    echos += [assetPath]
                elif actorClass == "BP_WeaponTrinketActor_C":
                    print(" Trinket: {}".format(assetPath))
                    trinkets += [assetPath]
                else:
                    print(" ???: {}".format(assetPath))
                    unknown += [assetPath]


pathFormat = "private static readonly List<string> {0}AssetPaths = new List<string>()"

assetSets = []
nameToList = {"emotes":emotes, "deco":decos, "head":heads,"skin":skins,"echo":echos,"unknown":unknown}

for name in nameToList:

    list = nameToList[name]
    assetSet = pathFormat.format(name) + '{\n'
    for asset in list:
        assetSet += '"{0}",\n'.format(asset)
    assetSet = assetSet[:-2] + "\n};"
    assetSets += [assetSet]

with open('output.txt', 'w') as outFile:
    completeSet = ""

    for assetSet in assetSets:
        completeSet += (assetSet + '\n')

    outFile.write(completeSet)
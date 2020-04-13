using System;
using OakSave;
using ProtoBuf;
using PackageIO;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using System.Windows.Data;
using BL3ProfileEditor.Debug;
using MahApps.Metro.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MahApps.Metro.Controls.Dialogs;
using BL3ProfileEditor.Protobufs.GVAS;
using Gibbed.Borderlands3.SaveFormats;
using Gibbed.Borderlands3.ProfileFormats;
using BL3ProfileEditor.Protobufs.Helpers;
using BL3ProfileEditor.Protobufs.Translations;

namespace BL3ProfileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        // TODO: Investigate `UnlockedInventoryCustomizationParts`
        public string filePath;

        public Profile loadedProfile;

        private byte[] originalBytes;
        private GVASSave saveData;
        private DebugConsole child;

        public MainWindow()
        {
            InitializeComponent();
        }

        #region UI Handling

        #region Button Clickings

        public async void showMessage(string title, string message)
        {
            await this.ShowMessageAsync(title, message);
        }

        #region Button Events
        private void OpenButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select BL3 Profile",
                Filter = "Profile|*.sav",
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "Borderlands 3", "Saved", "SaveGames")
            };

            if (fileDialog.ShowDialog() == true)
            {
                filePath = fileDialog.FileName;
                LoadFileFromDisk();
            }
        }

        private void SaveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SaveFileToDisk();
        }

        private void HelpButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            showMessage("Help", "Made by: FromDarkHell, icon courtesy of BrokenNoah (deviantart)");
        }

        private void OpenDebugMenu(object sender, System.Windows.RoutedEventArgs e)
        {
            child = new DebugConsole();
            child.Show();
        }

        #region Save Editing Shenanigans

        #region Customizations
        private void UnlockCustomizations(object sender, System.Windows.RoutedEventArgs e)
        {
            List<string> customizationAssetPaths = DataPathTranslations.GetCustomizationAssetPaths();
            List<OakCustomizationSaveGameData> saveData = loadedProfile.UnlockedCustomizations;
            List<OakCustomizationSaveGameData> output = new List<OakCustomizationSaveGameData>();

            foreach (string assetPath in customizationAssetPaths)
            {
                string lowerAsset = assetPath.ToLower();

                if (lowerAsset.Contains("default") || (lowerAsset.Contains("emote") && (lowerAsset.Contains("wave") || lowerAsset.Contains("cheer") || lowerAsset.Contains("laugh") || lowerAsset.Contains("point")))) continue;

                //if (!lowerAsset.Contains("beastmaster")) continue;

                bool bAlreadyOwnsCustomization = false;
                foreach (OakCustomizationSaveGameData customizatonData in saveData)
                {
                    if (customizatonData.CustomizationAssetPath.Equals(assetPath))
                    {
                        bAlreadyOwnsCustomization = true;
                        break;
                    }
                }
                if (!bAlreadyOwnsCustomization)
                {
                    OakCustomizationSaveGameData d = new OakCustomizationSaveGameData
                    {
                        CustomizationAssetPath = assetPath,
                        IsNew = true
                    };
                    output.Add(d);
                    Console.WriteLine("Doesn't own customization: {0}", assetPath);
                }
            }
            saveData.AddRange(output);
        }

        private void LockCustomizations(object sender, System.Windows.RoutedEventArgs e)
        {
            loadedProfile.UnlockedCustomizations.RemoveRange(0, loadedProfile.UnlockedCustomizations.Count);
        }
        #endregion

        #region Room Decorations
        private void UnlockRoomDecorations(object sender, System.Windows.RoutedEventArgs e)
        {
            List<string> roomDecos = DataPathTranslations.GetDecorationAssetPaths();
            foreach (string assetPath in roomDecos)
            {
                bool bAlreadyOwned = false;
                foreach (CrewQuartersDecorationItemSaveGameData d in loadedProfile.UnlockedCrewQuartersDecorations)
                {
                    if (d.DecorationItemAssetPath.Equals(assetPath))
                    {
                        bAlreadyOwned = true;
                        break;
                    }
                }
                if (!bAlreadyOwned)
                {
                    CrewQuartersDecorationItemSaveGameData d = new CrewQuartersDecorationItemSaveGameData()
                    {
                        DecorationItemAssetPath = assetPath,
                        IsNew = true
                    };
                    loadedProfile.UnlockedCrewQuartersDecorations.Add(d);
                    Console.WriteLine("Doesnt own room deco: {0}", assetPath);
                }
            }
        }

        private void LockRoomDecorations(object sender, System.Windows.RoutedEventArgs e)
        {
            loadedProfile.UnlockedCrewQuartersDecorations.RemoveRange(0, loadedProfile.UnlockedCrewQuartersDecorations.Count);
        }

        #endregion

        #region Lost Loot // Bank
        private void ClearLL(object sender, System.Windows.RoutedEventArgs e)
        {
            loadedProfile.LostLootInventoryLists.Clear();
        }

        private List<byte[]> getItemCodesFromString(string str)
        {
            string totalItemCodes = str;
            string[] itemCodes = totalItemCodes.Split(',');
            Console.WriteLine("Item Codes: {0}", string.Join(",", itemCodes));
            List<byte[]> output = new List<byte[]>();

            foreach (string itemCode in itemCodes)
            {
                if (!itemCode.ToLower().StartsWith("bl3(") || !itemCode.ToLower().EndsWith(")"))
                    continue;

                string base64Encoded = itemCode.Remove(0, 4);
                base64Encoded = base64Encoded.Remove(base64Encoded.Length - 1, 1);
                byte[] itemBytes = Convert.FromBase64String(base64Encoded);
                output.Add(itemBytes);
            }
            return output;
        }

        private void AddItemCodeToBank(object sender, System.Windows.RoutedEventArgs e)
        {
            loadedProfile.BankInventoryLists.AddRange(getItemCodesFromString(ItemCodeBox.Text));

        }

        #endregion

        private void InjectGRSaves(object sender, System.Windows.RoutedEventArgs e)
        {
            GRInjection();
        }

        private void GRInjection()
        {
            DirectoryInfo saveFiles = new DirectoryInfo(Path.GetDirectoryName(filePath));
            IEnumerable<FileInfo> infos = saveFiles.EnumerateFiles("*.sav");

            foreach (FileInfo saveFile in infos) // Get all of our .sav files
            {
                if (saveFile.IsReadOnly) continue;

                IO io = new IO(saveFile.FullName, Endian.Little, 0x0000000, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

                Console.WriteLine("Reading file \"{0}\"", saveFile.FullName);
                GVASSave gvas = Helpers.ReadGVASSave(io);

                if (gvas == null || !gvas.sgType.Equals("OakSaveGame"))
                {
                    Console.WriteLine("File \"{0}\" is not a save.", saveFile.FullName);
                    continue;
                }

                int remainingDataLength = io.ReadInt32();
                Console.WriteLine("Length of data: {0}", remainingDataLength);
                byte[] buf = io.ReadBytes(remainingDataLength);

                SaveBogoCrypt.Decrypt(buf, 0, remainingDataLength);

                Character characterSave = Serializer.Deserialize<Character>(new MemoryStream(buf));
                Console.WriteLine("Parsing save: {0}", characterSave.PreferredCharacterName);

                GuardianRankCharacterSaveGameData grcd = characterSave.GuardianRankCharacterData;
                if (grcd == null)
                {
                    io.Close();
                    continue;
                }

                grcd.GuardianAvailableTokens = loadedProfile.GuardianRank.AvailableTokens;
                grcd.GuardianExperience = loadedProfile.GuardianRank.GuardianExperience;
                grcd.NewGuardianExperience = loadedProfile.GuardianRank.NewGuardianExperience;
                grcd.GuardianRewardRandomSeed = loadedProfile.GuardianRank.GuardianRewardRandomSeed;
                grcd.GuardianRank = loadedProfile.GuardianRank.GuardianRank;
                List<GuardianRankRewardCharacterSaveGameData> outputGR = new List<GuardianRankRewardCharacterSaveGameData>();
                foreach (GuardianRankRewardCharacterSaveGameData grData in grcd.RankRewards)
                {
                    bool bFoundMatch = false;
                    foreach (GuardianRankRewardSaveGameData pGRData in loadedProfile.GuardianRank.RankRewards)
                    {
                        if (pGRData.RewardDataPath.Equals(grData.RewardDataPath))
                        {
                            grData.NumTokens = pGRData.NumTokens;
                            if (grData.NumTokens == 0)
                                outputGR.Add(grData);
                            bFoundMatch = true;
                        }
                    }

                    if (!bFoundMatch) outputGR.Add(grData);

                }
                outputGR = outputGR.Distinct().ToList();
                grcd.RankRewards.RemoveAll(x => outputGR.Contains(x));
                io.Close();


                io = new IO(saveFile.FullName, Endian.Little, 0x0000000, FileMode.Truncate, FileAccess.ReadWrite, FileShare.ReadWrite);
                Helpers.WriteGVASSave(io, gvas);
                byte[] result;
                using (var stream = new MemoryStream())
                {
                    Serializer.Serialize<Character>(stream, characterSave);
                    result = stream.ToArray();
                }
                SaveBogoCrypt.Encrypt(result, 0, result.Length);
                io.WriteInt32(result.Length);
                io.WriteBytes(result);

                io.Close();
            }

            Console.WriteLine("Done injecting GR into saves");
        }

        #endregion

        #endregion

        #endregion

        #region Save Display Data

        public ObservableCollection<StringIntPair> GetGuardianRewards()
        {
            ObservableCollection<StringIntPair> pairs = new ObservableCollection<StringIntPair>();
            foreach (string humanName in DataPathTranslations.GuardianRankRewards.Values)
            {
                bool bUpdatedRankData = false;
                foreach (GuardianRankRewardSaveGameData rankData in loadedProfile.GuardianRank.RankRewards)
                {
                    string h = DataPathTranslations.GetHumanRewardString(rankData.RewardDataPath);
                    if (h.Equals(humanName))
                    {
                        Console.WriteLine("Rank Data ({0}): {1}", humanName, rankData.NumTokens);
                        pairs.Add(new StringIntPair(humanName, rankData.NumTokens));
                        bUpdatedRankData = true;
                        break;
                    }
                }
                if (!bUpdatedRankData)
                    pairs.Add(new StringIntPair(humanName, 0));
            }

            return pairs;
        }

        public void UpdateSaveGUI()
        {
            UnspentTokensUp.IsEnabled = true;

            UnspentTokensUp.SetBinding(NumericUpDown.ValueProperty, new Binding("AvailableTokens") { Source = loadedProfile.GuardianRank });
            GuardianRank.SetBinding(NumericUpDown.ValueProperty, new Binding("GuardianRank") { Source = loadedProfile.GuardianRank });

            GuardianXP.SetBinding(NumericUpDown.ValueProperty, new Binding("NewGuardianExperience") { Source = loadedProfile.GuardianRank });

            GuardianRankDataGrid.ItemsSource = GetGuardianRewards();

            BankSDUs.SetBinding(NumericUpDown.ValueProperty, new Binding("SduLevel") { Source = loadedProfile.ProfileSduLists.Where(x => x.SduDataPath.Equals(DataPathTranslations.BankSDUAssetPath)) });
            LLSDUs.SetBinding(NumericUpDown.ValueProperty, new Binding("SduLevel") { Source = loadedProfile.ProfileSduLists.Where(x => x.SduDataPath.Equals(DataPathTranslations.LLSDUAssetPath)) });
            CSCurrency.SetBinding(NumericUpDown.ValueProperty, new Binding("CitizenScienceCSBucksAmount") { Source = loadedProfile });
        }

        #endregion

        #endregion

        #region File Management / Editing

        private void LoadFileFromDisk()
        {
            Console.WriteLine("\n\nReading new file: \"{0}\"", filePath);

            IO io = new IO(filePath, Endian.Little, 0x0000000, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            // We're gonna use this byte array for backing up the save file.
            originalBytes = io.ReadAll();
            io.Close();
            io = new IO(filePath, Endian.Little, 0x0000000, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

            saveData = Helpers.ReadGVASSave(io);
            if (saveData == null)
            {
                Console.WriteLine("Loaded file is not a BL3 profile...");
                showMessage("File Error", "Loaded file is not a BL3 profile");
                return;
            }
            string saveGameType = saveData.sgType;

            int remainingDataLength = io.ReadInt32();
            Console.WriteLine("Length of data: {0}", remainingDataLength);
            byte[] buf = io.ReadBytes(remainingDataLength);
            io.Close();

            if (!saveGameType.Equals("BP_DefaultOakProfile_C"))
            {
                Console.WriteLine("Loaded file is not a profile...");
                showMessage("File Error", "Loaded file is not a profile");
                return;
            }

            ProfileBogoCrypt.Decrypt(buf, 0, remainingDataLength);
            loadedProfile = Serializer.Deserialize<Profile>(new MemoryStream(buf));
            UpdateSaveGUI();
        }

        private void SaveFileToDisk()
        {
            IO io = new IO(filePath, Endian.Little, 0x0000000, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            File.WriteAllBytes(filePath + ".bak", originalBytes);
            ReadGUIData();

            Helpers.WriteGVASSave(io, saveData);

            byte[] result;
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize<Profile>(stream, loadedProfile);
                result = stream.ToArray();
            }
            ProfileBogoCrypt.Encrypt(result, 0, result.Length);

            io.WriteInt32(result.Length);
            io.WriteBytes(result);

            io.Close();

            Console.WriteLine("Injecting GR into saves...");
            GRInjection();
        }

        private void ReadGUIData()
        {
            foreach (StringIntPair p in GuardianRankDataGrid.Items)
            {
                string assetPath = DataPathTranslations.GetRewardAssetPathString(p.str);
                bool bRankDataSaved = false;

                foreach (GuardianRankRewardSaveGameData rankData in loadedProfile.GuardianRank.RankRewards)
                {
                    if (rankData.RewardDataPath.Equals(assetPath))
                    {
                        rankData.NumTokens = p.value;
                        bRankDataSaved = true;
                        break;
                    }
                }

                if (!bRankDataSaved)
                    loadedProfile.GuardianRank.RankRewards.Add(new GuardianRankRewardSaveGameData() { RewardDataPath = assetPath, NumTokens = p.value });

                if (p.value == 0)
                    loadedProfile.GuardianRank.RankRewards.RemoveAll(x => x.RewardDataPath.Equals(assetPath));
            }

            loadedProfile.GuardianRank.GuardianExperience = (int)loadedProfile.GuardianRank.NewGuardianExperience;
        }

        #endregion


    }
}

using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using PackageIO;
using System;
using System.IO;
using System.Text;
using ProtoBuf;

using OakSave;
using Gibbed.Borderlands3.ProfileFormats;
using System.Collections.ObjectModel;
using BL3ProfileEditor.Protobufs.Translations;
using System.Collections.Generic;
using System.Windows.Data;
using MahApps.Metro.Controls;
using BL3ProfileEditor.Debug;
using BL3ProfileEditor.Protobufs.GVAS;
using System.Linq;
using System.Windows.Controls;

namespace BL3ProfileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        // TODO: Clear Lost Loot (Done??)

        // TODO: Investigate `UnlockedInventoryCustomizationParts`

        // TODO: Add items to bank/LL (Gibbed code)
        // TODO: Mail GUIDs?
        // TODO: Refactoring

        public string filePath;
        public string strippedPath;

        public Profile loadedProfile;
        private GVASSave saveData;

        private DebugConsole child;

        public MainWindow()
        {
            InitializeComponent();
            strippedPath = Environment.CurrentDirectory + @"\Data\Stripped.dat";
            string dataDir = Environment.CurrentDirectory + @"\Data\";
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);
            DirectoryInfo directoryInfo = new DirectoryInfo(dataDir);
            directoryInfo.Attributes = FileAttributes.Hidden;
        }

        #region UI Handling

        #region Button Clickings
        public async void showMessage(string title, string message)
        {
            await this.ShowMessageAsync(title, message);
        }
        private void OpenButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Title = "Select BL3 Profile",
                Filter = "Profile|*.sav"
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


        private void AddItemCodeToBank(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        #endregion

        #endregion

        #endregion

        #region Save Display Data

        public ObservableCollection<StringIntPair> GetGuardianRewards()
        {
            ObservableCollection<StringIntPair> pairs = new ObservableCollection<StringIntPair>();
            if (loadedProfile == null || loadedProfile.GuardianRank == null || loadedProfile.GuardianRank.RankRewards.Count <= 0)
            {
                foreach (string humanName in DataPathTranslations.GuardianRankRewards.Values) pairs.Add(new StringIntPair(humanName, 0));
                return pairs;
            }
            foreach (GuardianRankRewardSaveGameData rankData in loadedProfile.GuardianRank.RankRewards)
            {
                string humanName = DataPathTranslations.GetHumanRewardString(rankData.RewardDataPath);
                Console.WriteLine("Rank Data ({0}): {1}", humanName, rankData.NumTokens);
                pairs.Add(new StringIntPair(humanName, rankData.NumTokens));
            }

            return pairs;
        }

        public class StringIntPair
        {
            public string str { get; set; } = "";
            public int value { get; set; } = 0;
            public StringIntPair(string name, int val)
            {
                str = name;
                value = val;
            }
        }


        public void UpdateSaveGUI()
        {
            UnspentTokensUp.IsEnabled = true;

            UnspentTokensUp.SetBinding(NumericUpDown.ValueProperty, new Binding("AvailableTokens")
            { Source = loadedProfile.GuardianRank });
            GuardianRank.SetBinding(NumericUpDown.ValueProperty, new Binding("GuardianRank")
            { Source = loadedProfile.GuardianRank });

            GuardianXP.SetBinding(NumericUpDown.ValueProperty, new Binding("GuardianExperience")
            { Source = loadedProfile.GuardianRank });

            GuardianRankDataGrid.ItemsSource = GetGuardianRewards();

            BankSDUs.SetBinding(NumericUpDown.ValueProperty, new Binding("SduLevel")
            { Source = loadedProfile.ProfileSduLists.Where(x => x.SduDataPath.Equals(DataPathTranslations.BankSDUAssetPath)) });
            LLSDUs.SetBinding(NumericUpDown.ValueProperty, new Binding("SduLevel")
            { Source = loadedProfile.ProfileSduLists.Where(x => x.SduDataPath.Equals(DataPathTranslations.LLSDUAssetPath)) });
        }

        #endregion

        #endregion

        #region File Management / Editing
        private void LoadFileFromDisk()
        {
            Console.WriteLine("\n\n\n\n\nReading new file: \"{0}\"\n", filePath);
            IO io = new IO(filePath, Endian.Little, 0x0000000, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            string saveGameType = ReadGVASSave(io);

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
            IO io = new IO(@"C:\Users\FromDarkHell\Documents\My Games\Borderlands 3\Saved\SaveGames\749a49478b93439a984b2703cbc1c46a\profile.sav", Endian.Little, 0x0000000, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);

            ReadGUIData();

            WriteGVASSave(io);
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

                if (!bRankDataSaved && p.value != 0)
                    loadedProfile.GuardianRank.RankRewards.Add(new GuardianRankRewardSaveGameData() { RewardDataPath = assetPath, NumTokens = p.value });
            }
        }

        #region GVAS Save Format Stuff
        private string ReadGVASSave(IO io)
        {
            string header = io.ReadASCII(4);
            Console.WriteLine("Header: {0}", header);
            int sgVersion = io.ReadInt32();
            Console.WriteLine("Save Game Version: {0}", sgVersion);
            int pkgVersion = io.ReadInt32();
            Console.WriteLine("Package version: {0}", pkgVersion);
            short major = io.ReadInt16();
            short minor = io.ReadInt16();
            short patch = io.ReadInt16();
            uint engineBuild = io.ReadUInt32();
            Console.WriteLine("Engine version: {0}.{1}.{2}.{3}", major, minor, patch, engineBuild);

            string buildId = Helpers.ReadUEString(io);
            Console.WriteLine("Build ID: {0}", buildId);

            int fmtVersion = io.ReadInt32();
            Console.WriteLine("Custom Format Version: {0}", fmtVersion);
            int fmtCount = io.ReadInt32();
            Console.WriteLine("Custom Format Data Count: {0}", fmtCount);
            Dictionary<byte[], int> keyValuePairs = new Dictionary<byte[], int>();
            for (int i = 0; i < fmtCount; i++)
            {
                byte[] guid = io.ReadBytes(16);
                int entry = io.ReadInt32();
                keyValuePairs.Add(guid, entry);
            }

            string sgType = Helpers.ReadUEString(io);
            Console.WriteLine("Save Game Type: {0}", sgType);
            saveData = new GVASSave(sgVersion, pkgVersion, major, minor, patch, engineBuild, buildId, fmtVersion, fmtCount, keyValuePairs, sgType);

            return sgType;
        }

        private void WriteGVASSave(IO io)
        {
            io.WriteASCII("GVAS");
            io.WriteInt32(saveData.sg);
            io.WriteInt32(saveData.pkg);
            io.WriteInt16(saveData.mj);
            io.WriteInt16(saveData.mn);
            io.WriteInt16(saveData.pa);
            io.WriteUInt32(saveData.eng);
            io.WriteUEString(saveData.build);
            io.WriteInt32(saveData.fmt);
            io.WriteInt32(saveData.fmtLength);
            foreach (KeyValuePair<byte[], int> entry in saveData.fmtData)
            {
                io.WriteBytes(entry.Key);
                io.WriteInt32(entry.Value);
            }
            io.WriteUEString(saveData.sgType);
        }



        #endregion

        #endregion

    }

    #region Extensions
    // Extensions courtesy of Rick (Gibbed)
    public static partial class Helpers
    {
        private static readonly Encoding Utf8 = new UTF8Encoding(false);

        public static MemoryStream ReadToMemoryStream(this Stream stream, long size, int buffer)
        {
            var memory = new MemoryStream();

            long left = size;
            var data = new byte[buffer];
            while (left > 0)
            {
                var block = (int)(Math.Min(left, data.Length));
                if (stream.Read(data, 0, block) != block)
                {
                    throw new EndOfStreamException();
                }
                memory.Write(data, 0, block);
                left -= block;
            }

            memory.Seek(0, SeekOrigin.Begin);
            return memory;
        }

        public static MemoryStream ReadToMemoryStream(this Stream stream, long size)
        {
            return stream.ReadToMemoryStream(size, 0x40000);
        }

        public static string ReadUEString(this IO io)
        {
            if (io.PeekChar() < 0) return null;
            int length = io.ReadInt32();
            if (length == 0) return null;
            if (length == 1) return "";
            var valueBytes = io.ReadBytes(length);
            return Utf8.GetString(valueBytes, 0, valueBytes.Length - 1);
        }

        public static void WriteUEString(this IO io, string str)
        {
            if (str == null) io.WriteInt32(0);
            else if (string.Empty.Equals(str)) io.WriteInt32(1);
            else
            {
                byte[] data = Utf8.GetBytes(str + '\0');
                io.WriteInt32(data.Length);
                io.WriteBytes(data);
            }
        }

    }


    #endregion

}

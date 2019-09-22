using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using PackageIO;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using static BL3ProfileEditor.BL3;

namespace BL3ProfileEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public static Entry[] Entries;
        public string filePath;
        public int brokenEntries = 0;
        public string strippedPath;
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
                long pos = 1262;
                /*                uint length = io.ReadUInt32(Endian.Big);
                byte[] decompressed = new byte[(int)((ulong)length - 1UL) + 1];
                */
                IO io = new IO(filePath, Endian.Little, pos, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                byte[] remainingFile = io.ReadBytes((int)(io.Length - (pos)), Endian.Little);
                io.Close(true, true);
                File.WriteAllBytes(strippedPath, remainingFile);
                identifyEntryTypes();
            }
        }

        private void SaveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }


        private void HelpButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            showMessage("Help", "Made by: FromDarkHell, icon courtesy of BrokenNoah (deviantart)");
        }

        #endregion

        #region File Management / Editing
        private void identifyEntryTypes()
        {
            Reader reader = new Reader(strippedPath, Endian.Big, 0L, FileAccess.Read, FileShare.ReadWrite);
            brokenEntries = 0;
            int entryLength = (int)reader.ReadUInt32();
            Array.Resize(ref Entries, entryLength);
            int index = 0;
            while (reader.LengthToEnd != 0L)
            {
                if (reader.ReadByte() != 0)
                {
                    Entry entry = Entries[index];
                    entry.ID = reader.ReadInt32();
                    byte dataType = reader.ReadByte();
                    entry.dataType = (DataType)dataType;
                    entry.Offset = (int)reader.Position;
                    switch (entry.dataType)
                    {
                        case DataType.Int32:
                            entry.Value = reader.ReadInt32();
                            break;
                        case DataType.String:
                            entry.Length = reader.ReadInt32();
                            entry.Value = reader.ReadASCII(entry.Length);
                            break;
                        case DataType.Single:
                            entry.Value = reader.ReadSingle();
                            break;
                        case DataType.Binary:
                            entry.Length = reader.ReadInt32();
                            entry.Bin = reader.ReadBytes(entry.Length, Endian.Little);
                            break;
                        case DataType.Int8:
                            entry.Value = reader.ReadInt8();
                            break;
                    }
                    Entries[index] = entry;
                    reader.Position += 1L;
                    index++;
                }
                else
                {
                    brokenEntries++;
                    reader.Position += 6L;
                }
            }
            if (brokenEntries != 0)
            {
                Array.Resize(ref Entries, Entries.Length - brokenEntries);
            }
            reader.Close(true, true);
        }

        #endregion

    }
}

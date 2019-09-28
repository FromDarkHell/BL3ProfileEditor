using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using PackageIO;
using System;
using System.IO;
using ProtoSerializer = ProtoBuf.Serializer;
using System.Security.Cryptography;
using static BL3ProfileEditor.BL3;
using System.Linq;

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

        public Profile loadedProfile;


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
            IO io = new IO(filePath, Endian.Little, 0x000004D4, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            /*var sha1Hash = io.ReadBytes(3, Endian.Little);
            byte[] computedSha1Hash;
            using (var sha1 = new SHA1Managed())
            {
                computedSha1Hash = sha1.ComputeHash(io.ReadAll());
            }*/
            string type = new string(io.ReadChars(22));
            var loadedProfile = ProtoSerializer.Deserialize<Profile>(io.CurrentStream);
            int bgd = 0;
            io.Close(true, true);

        }
        #endregion

    }

    #region Extensions
    // Extensions courtesy of Rick (Gibbed)
    public static partial class Helpers
    {
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

    }


    #endregion

}

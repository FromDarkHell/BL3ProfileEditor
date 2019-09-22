using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL3ProfileEditor
{
    public class BL3
    {
        public enum DataType
        {
            Int32 = 1,
            String = 4,
            Single,
            Binary,
            Int8 = 8
        }

        public struct Entry
        {
            public int ID;
            public int Offset;
            public int Length;
            public DataType dataType;
            public byte[] Bin;
            public object Value;
        }

        public static object GetEntryValue(int ID)
        {
            for (int i = 0; i <= MainWindow.Entries.Length - 1; i++)
            {
                if (MainWindow.Entries[i].ID == ID) return MainWindow.Entries[i].Value;
            }
            return null;
        }

        public static int GetEntryIndex(int ID)
        {
            for (int i = 0; i <= MainWindow.Entries.Length - 1; i++)
            {
                if (MainWindow.Entries[i].ID == ID) return i;
            }
            return 0;
        }

        public static bool EntryExists(int ID)
        {
            for (int i = 0; i <= MainWindow.Entries.Length - 1; i++)
            {
                if (MainWindow.Entries[i].ID == ID) return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL3ProfileEditor.Protobufs.Helpers
{
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
}

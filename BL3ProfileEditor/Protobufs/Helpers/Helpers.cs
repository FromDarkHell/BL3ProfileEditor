namespace BL3ProfileEditor.Protobufs.Helpers
{
    public class StringIntPair
    {
        public string str { get; set; } = "";
        public double Value { get; set; } = 0;
        public StringIntPair(string name, int val)
        {
            str = name;
            Value = val;
        }
    }
}

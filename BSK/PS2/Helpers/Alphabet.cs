using System.Collections.Generic;
using System.Text;

namespace BSK.PS2
{
    public static class Alphabet
    {
        public static Dictionary<int, int> GetDictionary() => chars;

        private static Dictionary<int, int> MapDictioniary()
        {
            var dict = new Dictionary<int, int>();
            int i = 0;
            foreach (char c in alphabet)
                dict.Add(i++, asciiValues[i - 1]);

            return dict;
        }

        private static readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static byte[] asciiValues = Encoding.ASCII.GetBytes(alphabet);
        private static readonly Dictionary<int, int> chars = MapDictioniary();
    }
}

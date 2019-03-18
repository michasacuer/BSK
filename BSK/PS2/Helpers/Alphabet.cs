using System.Collections.Generic;
using System.Text;

namespace BSK.PS2
{
    public static class Alphabet
    {
        /// <summary>
        /// Get alphabet's Dictionary
        /// </summary>
        /// <returns>Keys from 0 to 25 and related Values are from ASCII table</returns>
        public static Dictionary<int, int> GetDictionary() => chars;

        /// <summary>
        /// Converts alphabet to ASCII values and map it to dictionary
        /// </summary>
        /// <returns>Dictionary with alphabet</returns>
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

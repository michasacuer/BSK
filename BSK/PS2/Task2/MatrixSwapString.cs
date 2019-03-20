using System.Collections.Generic;

namespace BSK.PS2
{
    public abstract class MatrixSwapString
    {
        public string key { get; set; }
        public Dictionary<int, int> mappedKey = new Dictionary<int, int>();
        public readonly string alphabet = Alphabet.GetAsString();

        public MatrixSwapString(string key)
        {
            key = key.ToUpper();

            for (int i = 0; i < alphabet.Length; i++)
                for (int j = 0; j < key.Length; j++)
                    if (alphabet[i] == key[j])
                        mappedKey.Add(mappedKey.Count, j);

            this.key = key;
        }
    }
}

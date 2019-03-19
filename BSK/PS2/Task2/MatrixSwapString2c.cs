using System;
using System.Collections.Generic;
using System.Text;

namespace BSK.PS2.Task2
{
    public class MatrixSwapString2c : IAlgorithm
    {
        public MatrixSwapString2c(string key)
        {
            string alphabet = Alphabet.GetAsString();
            key = key.ToUpper();

            for (int i = 0; i < alphabet.Length; i++)
                for (int j = 0; j < key.Length; j++)
                {
                    if (alphabet[i] == key[j])
                        mappedKey.Add(mappedKey.Count, j);
                }

            this.key = key;
        }

        public string Encrypt(string input)
        {
            throw new NotImplementedException();
        }

        public string Decrypt(string input)
        {
            throw new NotImplementedException();
        }

        private string key { get; set; }
        private Dictionary<int, int> mappedKey = new Dictionary<int, int>();
    }
}

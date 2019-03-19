using System;
using System.Collections.Generic;
using System.Text;

namespace BSK.PS2
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
            input = input.ToUpper();
            string result = string.Empty;
            char[,] chars = new char[key.Length, key.Length];

            int charCounter = 0;
            for(int i = 0; i < key.Length; i++)
            {
                int stride = mappedKey[i] + 1;
                for (int j = 0; j < stride; j++)
                {
                    if (charCounter < input.Length)
                        chars[i, j] = input[charCounter++];
                    else
                        break;
                }
            }

            for (int i = 0; i < chars.GetLength(1); i++)
                for (int j = 0; j < chars.GetLength(0); j++)
                {
                    if (chars[j, mappedKey[i]] != 0)
                        result += chars[j, mappedKey[i]];

                    if (j == chars.GetLength(0) - 1)
                        result += " ";
                }

            return result;
        }

        public string Decrypt(string input)
        {
            throw new NotImplementedException();
        }

        private string key { get; set; }
        private Dictionary<int, int> mappedKey = new Dictionary<int, int>();
    }
}

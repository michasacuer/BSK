using System;
using System.Collections.Generic;
using System.Linq;

namespace BSK.PS2
{
    public class MatrixSwapString : IAlgorithm
    {
        public MatrixSwapString(string key)
        {
            string alphabet = Alphabet.GetAsString();
            key = key.ToUpper();

            for (int i = 0; i < alphabet.Length; i++)
                for(int j = 0; j < key.Length; j++)
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
            int maxResultLength = (int)Math.Ceiling((double)input.Length / key.Length) * key.Length;
            int columnHeight = (int)Math.Ceiling((double)input.Length / key.Length);
            char[,] chars = new char[key.Length, columnHeight];

            for (int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < input.Length; j++)
                {
                    int stride = j * key.Length;
                    if (mappedKey[i] + stride >= input.Length)
                    {
                        if (mappedKey[i] + stride < maxResultLength)
                            result += " ";
                        break;
                    }
                    else
                        result += input[mappedKey[i] + stride];
                }
                if (result.Length >= input.Length)
                    break;
            }
            
            return result;
        }

        public string Decrypt(string input)
        {
            input = input.ToUpper();
            string result = string.Empty;
            int columnHeight = (int)Math.Ceiling((double)input.Length / key.Length);
            char[,] chars = new char[key.Length, columnHeight];
            char[,] decryptChars = new char[key.Length, columnHeight];
            var reversedDict = mappedKey.ToDictionary(a => a.Value, a => a.Key);

            int charCounter = 0;
            for (int i = 0; i < chars.GetLength(0); i++)
                for (int j = 0; j < chars.GetLength(1); j++)
                    chars[i, j] = input[charCounter++];
            
            for (int i = 0; i < chars.GetLength(0); i++)
                for (int j = 0; j < chars.GetLength(1); j++)
                    decryptChars[i, j] = chars[reversedDict[i], j];

            for (int i = 0; i < chars.GetLength(1); i++)
                for (int j = 0; j < chars.GetLength(0); j++)
                    result += decryptChars[j, i];

            return result;
            
        }

        private string key { get; set; }
        private Dictionary<int, int> mappedKey = new Dictionary<int, int>();
    }
}

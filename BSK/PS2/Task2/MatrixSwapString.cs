using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BSK.PS2
{
    public class MatrixSwapString : IAlgorithm
    {
        public MatrixSwapString(string key)
        {
            string alphabet = Alphabet.GetAlphabet();
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
            string result = string.Empty;
            int condition = (int)Math.Ceiling((double)input.Length / key.Length) * key.Length;

            for (int i = 0; i < key.Length; i++)
            {
                for(int j = 0; j < key.Length; j++)
                {
                    int stride = j * key.Length;
                    if (mappedKey[i] + stride >= input.Length)
                    {
                        if (mappedKey[i] + stride > input.Length && mappedKey[i] + stride <= condition)
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
            throw new NotImplementedException();
        }

        private string key { get; set; }
        private Dictionary<int, int> mappedKey = new Dictionary<int, int>();
    }
}

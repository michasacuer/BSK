using System;
using System.Linq;
using System.Text;

namespace BSK.PS2
{
    public class MatrixSwapString2b : MatrixSwapString, IAlgorithm
    {
        public MatrixSwapString2b(string key) : base(key) { }

        public string Encrypt(string input)
        {
            input = input.ToUpper();
            StringBuilder result = new StringBuilder();
            int maxResultLength = (int)Math.Ceiling((double)input.Length / key.Length) * key.Length;
            int columnHeight = (int)Math.Ceiling((double)input.Length / key.Length);

            for (int i = 0; i < input.Length; i++)
            {
                for(int j = 0; j < input.Length; j++)
                {
                    int stride = j * key.Length;
                    if (mappedKey[i] + stride >= input.Length)
                    {
                        if (mappedKey[i] + stride < maxResultLength)
                            result.Append(" ");
                        break;
                    }
                    else
                        result.Append(input[mappedKey[i] + stride]);
                }
                if (result.Length >= input.Length)
                    break;
            }
            
            return result.ToString();
        }

        public string Decrypt(string input)
        {
            input = input.ToUpper();
            StringBuilder result = new StringBuilder();
            int columnHeight = (int)Math.Ceiling((double)input.Length / key.Length);
            char[,] chars = new char[key.Length, columnHeight];
            char[,] decryptChars = new char[key.Length, columnHeight];
            var reversedDict = mappedKey.ToDictionary(a => a.Value, a => a.Key);

            int charCounter = 0;
            for (int i = 0; i < chars.GetLength(0); i++)
                for (int j = 0; j < chars.GetLength(1); j++)
                    if (charCounter < input.Length)
                        chars[i, j] = input[charCounter++];
            
            for (int i = 0; i < chars.GetLength(0); i++)
                for (int j = 0; j < chars.GetLength(1); j++)
                    decryptChars[i, j] = chars[reversedDict[i], j];

            for (int i = 0; i < chars.GetLength(1); i++)
                for (int j = 0; j < chars.GetLength(0); j++)
                    result.Append(decryptChars[j, i]);

            return result.ToString();
        }
    }
}

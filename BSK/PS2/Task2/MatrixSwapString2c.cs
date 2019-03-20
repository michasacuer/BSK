using System.Linq;
using System.Text;

namespace BSK.PS2
{
    public class MatrixSwapString2c : MatrixSwapString, IAlgorithm
    {
        public MatrixSwapString2c(string key) : base(key) { }

        public string Encrypt(string input)
        {
            input = input.Replace(" ", string.Empty).ToUpper();
            StringBuilder result = new StringBuilder();
            char[,] chars = new char[key.Length, key.Length];

            int charCounter = 0;
            for(int i = 0; i < key.Length; i++)
            {
                int stride = mappedKey[i] + 1;
                for (int j = 0; j < key.Length; j++)
                {
                    if (charCounter < input.Length && j < stride)
                        chars[i, j] = input[charCounter++];
                    else
                        break;
                }
            }

            for (int i = 0; i < chars.GetLength(1); i++)
                for (int j = 0; j < chars.GetLength(0); j++)
                {
                    if (chars[j, mappedKey[i]] != 0)
                        result.Append(chars[j, mappedKey[i]]);
                    else
                        result.Append(" ");
                }

            return result.ToString();
        }

        public string Decrypt(string input)
        {
            input = input.ToUpper();
            StringBuilder result = new StringBuilder();
            char[,] chars = new char[key.Length, key.Length];
            char[,] decryptChars = new char[key.Length, key.Length];
            var reversedDict = mappedKey.ToDictionary(a => a.Value, a => a.Key);

            int charCounter = 0;
            for (int i = 0; i < chars.GetLength(0); i++)
                for (int j = 0; j < chars.GetLength(1); j++)
                    if(charCounter < input.Length)
                        chars[i, j] = input[charCounter++];
            
            for (int i = 0; i < chars.GetLength(0); i++)
                for (int j = 0; j < chars.GetLength(1); j++)
                    decryptChars[i, j] = chars[reversedDict[i], j];

            for (int i = 0; i < chars.GetLength(1); i++)
                for (int j = 0; j < chars.GetLength(0); j++)
                    result.Append(decryptChars[j, i]);

            return result.ToString().Replace(" ", string.Empty);
        }
    }
}

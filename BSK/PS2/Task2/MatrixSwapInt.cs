using System.Text;

namespace BSK.PS2
{
    public class MatrixSwapInt : IAlgorithm
    {
        public MatrixSwapInt(int d, params int[] key)
        {
            this.d = d;
            this.key = key;
        }

        public string Encrypt(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int stride = i * key.Length - i;
                for (int j = 0; j < key.Length; j++)
                {
                    if (key[j] - 1 + i + stride >= input.Length)
                        result.Append(" ");
                    else
                        result.Append(input[key[j] - 1 + i + stride]);
                }
                if (result.Length >= input.Length)
                    break;
            }
            return result.ToString();
        }

        public string Decrypt(string input)
        {
            StringBuilder result = new StringBuilder();
            int charCounter = 0;

            char[,] chars = new char[input.Length, key.Length];

            for(int i = 0; i < chars.GetLength(0); i++)
                for(int j = 0; j < chars.GetLength(1); j++)
                {
                    if (charCounter >= input.Length)
                        break;
                    chars[i, j] = input[charCounter++];
                }
            
            for(int i = 0; i <  chars.GetLength(0); i++)    
                for(int j = key.Length - 1; j >= 0; j--)       
                    if(chars[i, key[j] - 1] != 0)
                        result.Append(chars[i, key[j] - 1]); 

            return result.ToString().Replace(" ", string.Empty);
        }

        private int d { get; set; }
        private int[] key { get; set; }
    }
}

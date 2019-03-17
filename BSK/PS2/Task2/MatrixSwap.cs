    namespace BSK.PS2
{
    public class MatrixSwap : Algorithm
    {
        public MatrixSwap(int d, params int[] key)
        {
            this.d = d;
            this.key = key;
        }

        public override string Encrypt(string input)
        {
            string result = string.Empty;

            for (int i = 0; i < d; i++)
            {
                int stride = i * key.Length - i;
                for (int j = 0; j < key.Length; j++)
                {
                    if (key[j] - 1 + i + stride >= input.Length)
                        continue;
                    result += input[key[j] - 1 + i + stride];
                }
            }

            return result;
        }

        public override string Decrypt(string input)
        {
            string result = string.Empty;
            int charCounter = 0;

            char[,] chars = new char[d, key.Length];

            for(int i = 0; i < chars.GetLength(0); i++)
                for(int j = 0; j < chars.GetLength(1); j++)
                {
                    if (charCounter >= input.Length)
                        break;
                    chars[i, j] = input[charCounter++];
                }
            
            for(int i = 0; i <  chars.GetLength(0); i++)    
                for(int j = key.Length - 1; j >= 0; j--)
                {
                    if (chars[i, key[j] - 1] == 0)
                        continue;
                    result += chars[i, key[j] - 1]; 
                }

            return result;
        }

        private int d { get; set; }
        private int[] key { get; set; }
    }
}

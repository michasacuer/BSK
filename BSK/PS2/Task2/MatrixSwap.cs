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
            int charCounter = 0;
            char[,] chars = new char[d, d];

            for (int i = 0; i < d; i++)
                for (int j = 0; j < d; j++)
                {
                    if (charCounter >= input.Length)
                        break;
                    chars[i, j] = input[charCounter++];
                }

            string result = string.Empty;
            for (int i = 0; i < d; i++)
                for(int j = 0; j < key.Length; j++)
                    if(chars[i, key[j] - 1] != 0)
                        result += chars[i, key[j] - 1];

            return result;
        }

        private int d { get; set; }
        private int[] key { get; set; }
    }
}

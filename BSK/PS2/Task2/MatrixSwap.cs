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
                int stride = 0;
                if (i >= 1)
                    stride = i * key.Length - i;
                for (int j = 0; j < key.Length; j++)
                {
                    if (key[j] - 1 + i + stride >= input.Length)
                        continue;
                    result += input[key[j] - 1 + i + stride];
                }
            }

            return result;
        }

        private int d { get; set; }
        private int[] key { get; set; }
    }
}

namespace BSK.PS2
{
    public class RailFence : Algorithm
    {
        public RailFence(int n) { this.n = n; }

        public override string Encrypt(string input)
        {
            int charCounter = 0;
            bool isIncreasing = true;
            char[,] chars = new char[n, input.Length];

            //Zig-Zag pattern
            while(charCounter < input.Length - 1)
            {
                if(charCounter == 0)
                    chars[0, 0] = input[charCounter];

                if (!isIncreasing)
                {
                    for (int i = n - 2; i >= 0; --i)
                        if (charCounter + 1 < input.Length)
                            chars[i, ++charCounter] = input[charCounter];
                    isIncreasing = true;
                }

                if(isIncreasing)
                {
                    for (int i = 1; i < n; i++)
                        if(charCounter + 1 < input.Length)
                            chars[i, ++charCounter] = input[charCounter];
                    isIncreasing = false;
                }
            }

            //Encryption
            string result = string.Empty;
            foreach (char c in chars)
                if (c != 0)
                    result += c;
            
            return result;
        }

        private int n { get; set; }
    }
}

namespace BSK.PS2
{
    public class RailFence : Algorithm
    {
        public RailFence(int n) { this.n = n; }

        public override string Encrypt(string input)
        {
            char[,] chars = ZigZagFromString(input);

            string result = string.Empty;
            foreach (char c in chars)
                if (c != 0)                                                                                                                                         
                    result += c;
            
            return result;
        }
    
        public override string Decrypt(string input)
        {
            char[,] chars = ZigZagFromString(input);
            return ZigZagDecrypt(MapCharsToZigZag(chars, input), input);
        }

        private char[,] ZigZagFromString(string input)
        {
            int charCounter = 0;
            bool isIncreasing = true;
            char[,] chars = new char[n, input.Length];

            while (charCounter < input.Length - 1)
            {
                if (charCounter == 0)
                    chars[0, 0] = input[charCounter];

                if (!isIncreasing)
                {
                    for (int i = n - 2; i >= 0; --i)
                        if (charCounter + 1 < input.Length)
                            chars[i, ++charCounter] = input[charCounter];
                    isIncreasing = true;
                }

                if (isIncreasing)
                {
                    for (int i = 1; i < n; i++)
                        if (charCounter + 1 < input.Length)
                            chars[i, ++charCounter] = input[charCounter];
                    isIncreasing = false;
                }
            }

            return chars;
        }

        private string ZigZagDecrypt(char[,] chars, string input)
        {
            bool isIncreasing = true;
            int charCounter = 0;
            string result = string.Empty;

            while (charCounter < input.Length - 1)
            {
                if (charCounter == 0)
                    result += chars[0, 0];

                if (!isIncreasing)
                {
                    for (int i = n - 2; i >= 0; --i)
                        if (charCounter + 1 < input.Length)
                            result += chars[i, ++charCounter];
                    isIncreasing = true;
                }

                if (isIncreasing)
                {
                    for (int i = 1; i < n; i++)
                        if (charCounter + 1 < input.Length)
                            result += chars[i, ++charCounter];
                    isIncreasing = false;
                }
            }

            return result;
        }

        private char[,] MapCharsToZigZag(char[,] chars, string input)
        {
            int charCounter = 0;

            for (int i = 0; i < chars.GetLength(0); i++)
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    if (chars[i, j] == 0)
                        continue;
                    if (charCounter >= input.Length)
                        break;
                    chars[i, j] = input[charCounter++];
                }

            return chars;
        }

        private int n { get; set; }
    }
}

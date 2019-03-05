using System;
using System.Collections.Generic;
using System.Text;

namespace BSK.PS2
{
    public class RailFence : Algorithm
    {
        public RailFence(int n) { this.n = n; }

        public override string Encrypt(string input)
        {
            int charCounter = 0;
            int nCounter = 0;
            char[,] chars = new char[n, input.Length];

            //Zig-Zag pattern
            int j = 0;
            while(charCounter <= input.Length)
            {
                if (charCounter >= input.Length)
                    break;

                chars[nCounter++, j++] = input[charCounter++];
                if (nCounter == n)
                    for (int i = nCounter; i >= 0; i--)
                    {
                        if (charCounter >= input.Length)
                            break;
                        if (nCounter == 0)
                            break;
                        chars[nCounter--, j++] = input[charCounter++];
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

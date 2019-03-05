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
            bool backward = false;
            char[,] chars = new char[n, input.Length];

            //Zig-Zag pattern
            while(charCounter < input.Length - n)
            {
                if(charCounter == 0)
                    chars[0, 0] = input[charCounter];

                if (backward)
                {
                    for (int i = n-2; i >= 0; --i)
                        if (charCounter < input.Length)
                            chars[i, ++charCounter] = input[charCounter];
                    backward = false;
                }

                if(!backward)
                {
                    for (int i = 1; i < n; i++)
                        if(charCounter < input.Length)
                            chars[i, ++charCounter] = input[charCounter];
                    backward = true;
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

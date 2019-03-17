using System.Collections.Generic;
using System.Text;

namespace BSK.PS2
{
    public class Vigenere : Algorithm
    {
        public Vigenere(string key)
        {
            int i = 0;
            this.key = key.ToUpper();
            foreach (char c in alphabet)
                chars.Add(i++, asciiValues[i-1]);
        }

        public override string Encrypt(string input)
        {
            input = input.ToUpper();
            string newKey = GenerateNewKey(input.Length);

            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
                    result += VigenereEncryption(input[i], newKey[i]);

            return result;
        }

        public override string Decrypt(string input)
        {
            input = input.ToUpper();
            string newKey = GenerateNewKey(input.Length);

            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
                result += VigenereDecryption(input[i], newKey[i]);

            return result;
        }

        private char VigenereEncryption(char p, char k) => (char)chars[(p + k) % 26];
        private char VigenereDecryption(char p, char k) => (char)chars[(p - k + 26) % 26];
        private string GenerateNewKey(int length)
        {
            string newKey = string.Empty;
            int charCounter = 0;
            while (charCounter < length)
                newKey += key[charCounter++ % key.Length];
            return newKey;
        }

        private string key { get; set; }
        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private byte[] asciiValues = Encoding.ASCII.GetBytes(alphabet);
        private Dictionary<int, int> chars = new Dictionary<int, int>();
    }
}

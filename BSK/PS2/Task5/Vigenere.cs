using System.Collections.Generic;

namespace BSK.PS2
{
    public class Vigenere : IAlgorithm
    {
        public Vigenere(string key) { this.key = key.ToUpper(); }

        public string Encrypt(string input)
        {
            input = input.ToUpper();
            string newKey = GenerateNewKey(input.Length);

            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
                    result += VigenereEncryption(input[i], newKey[i]);

            return result;
        }

        public string Decrypt(string input)
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
        private Dictionary<int, int> chars { get; } = Alphabet.GetAsDictionary();
    }
}

using System.Collections.Generic;
using System.Text;

namespace BSK.PS2
{
    public class Vigenere : IAlgorithm
    {
        public Vigenere(string key) { this.key = key.ToUpper(); }

        public string Encrypt(string input)
        {
            input = input.ToUpper();
            string newKey = GenerateNewKey(input.Length);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
                result.Append(VigenereEncryption(input[i], newKey[i]));

            return result.ToString();
        }

        public string Decrypt(string input)
        {
            input = input.ToUpper();
            string newKey = GenerateNewKey(input.Length);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
                result.Append(VigenereDecryption(input[i], newKey[i]));

            return result.ToString();
        }

        private char VigenereEncryption(char p, char k) => (char)chars[(p + k) % 26];
        private char VigenereDecryption(char p, char k) => (char)chars[(p - k + 26) % 26];
        private string GenerateNewKey(int length)
        {
            StringBuilder newKey = new StringBuilder();
            int charCounter = 0;
            while (charCounter < length)
                newKey.Append(key[charCounter++ % key.Length]);
            return newKey.ToString();
        }

        private string key { get; set; }
        private Dictionary<int, int> chars { get; } = Alphabet.GetAsDictionary();
    }
}

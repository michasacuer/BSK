namespace BSK.PS2
{
    public class Vigenere : Algorithm
    {
        public Vigenere(string key) { this.key = key; }

        public override string Encrypt(string input)
        {
            string newKey = string.Empty;
            int charCounter = 0;
            while (charCounter < input.Length)
                newKey += key[charCounter++ % key.Length];

            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
                result += VigenereEncryption(input[i], newKey[i]);

            return result;
        }

        private char VigenereEncryption(char p, char k) => (char)((p + k) % 26);
        private char VigenereDecryption(char p, char k) => (char)((p - k + 26) % 26);

        private string key { get; set; }
    }
}

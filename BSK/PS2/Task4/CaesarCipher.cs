using System;
using System.Collections.Generic;
using System.Linq;

namespace BSK.PS2
{
    public class CaesarCipher : Algorithm
    {
        public CaesarCipher(int k1, int k0) { this.k1 = k1; this.k0 = k0; }

        public override string Encrypt(string input)
            => string.Concat(input.Select(c => (char)chars[(c * k1 + k0) % 26]));

        public override string Decrypt(string input)
            => string.Concat(input.Select(c => (char)chars[(int)((c + (26 - k0)) * Math.Pow(k1, phi - 1) % 26)]));

        private Dictionary<int, int> chars { get; } = Alphabet.GetDictionary();
        private int k1 { get; set; }
        private int k0 { get; set; }
        private const int phi = 12;
    }
}

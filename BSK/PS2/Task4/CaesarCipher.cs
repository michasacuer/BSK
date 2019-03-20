using System;
using System.Collections.Generic;
using System.Linq;

namespace BSK.PS2
{
    public class CaesarCipher : IAlgorithm
    {
        public CaesarCipher(int k1, int k0) { this.k1 = k1; this.k0 = k0; calculatedPhi = Math.Pow(k1, phi - 1); }

        public string Encrypt(string input)
            => string.Concat(input.Select(c => (char)chars[(c * k1 + k0) % 26]));

        public string Decrypt(string input)
            => string.Concat(input.Select(c => (char)chars[(int)((c + (26 - k0)) * calculatedPhi % 26)]));

        private Dictionary<int, int> chars { get; } = Alphabet.GetAsDictionary();
        private int k1 { get; set; }
        private int k0 { get; set; }
        private double calculatedPhi { get; set; }
        private const int phi = 12;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BSK.PS2
{
    public class CaesarCipher : Algorithm
    {
        public override string Encrypt(string input)
        {
            throw new NotImplementedException();
        }

        public override string Decrypt(string input)
        {
            throw new NotImplementedException();
        }

        private static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private byte[] asciiValues = Encoding.ASCII.GetBytes(alphabet);
        private Dictionary<int, int> chars = new Dictionary<int, int>();
    }
}

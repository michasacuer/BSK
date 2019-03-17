using System;

namespace BSK
{
    public abstract class Algorithm
    {
        public abstract string Encrypt(string input);
        public abstract string Decrypt(string input);
    }
}

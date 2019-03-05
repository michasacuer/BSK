using System;

namespace BSK
{
    public abstract class Algorithm
    {
        public abstract string Encrypt(string input);
        public virtual  string Decrypt(string input)
            => throw new NotImplementedException("You need to implement this function on your own " +
                                                 "if you want to use decrytpion algorithm!");
    }
}

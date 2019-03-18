using System;
using System.Collections.Generic;
using System.Text;

namespace BSK.PS2.Task2
{
    public class MatrixSwapString : Algorithm
    {
        public MatrixSwapString(string key) { this.key = key.ToUpper(); }

        public override string Encrypt(string input)
        {
            throw new NotImplementedException();
        }

        public override string Decrypt(string input)
        {
            throw new NotImplementedException();
        }

        private string key { get; set; }
    }
}

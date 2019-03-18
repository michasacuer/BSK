using BSK.PS2;
using System;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixSwapString matrixSwap = new MatrixSwapString("CONVENIENCE");
            string e = matrixSwap.Encrypt("HERE IS A SECRET MESSAGE ENCIPHERED BY TRANSPOSITION");
            Console.WriteLine(e);
            Console.WriteLine(matrixSwap.Decrypt(e));
            Console.ReadKey();
        }
    }
}

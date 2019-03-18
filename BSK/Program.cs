using BSK.PS2;
using System;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixSwapString matrixSwap = new MatrixSwapString("CONVENIENCE");
            Console.WriteLine(matrixSwap.Encrypt("HERE IS A SECRET MESSAGE ENCIPHERED BY TRANSPOSITION"));
            Console.ReadKey();
        }
    }
}

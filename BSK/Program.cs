using BSK.PS2;
using System;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixSwapString2c matrixSwap = new MatrixSwapString2c("CONVENIENCE");
            string encrypted = matrixSwap.Encrypt("HEREISASECRETMESSAGEENCIPHEREDBYTRANSPOSITION");
            Console.WriteLine(encrypted);
            Console.WriteLine(matrixSwap.Decrypt(encrypted));

            Console.ReadKey();
        }
    }
}

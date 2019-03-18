using System;
using BSK.PS2;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatrixSwapInt matrixSwap = new MatrixSwapInt(5, 3, 4, 1, 5, 2);
            string encrypted = matrixSwap.Encrypt("CRYPTOGRAPHYOSA");
            Console.WriteLine(encrypted);
            Console.WriteLine(matrixSwap.Decrypt(encrypted));

            Console.ReadKey();
        }
    }
}

using System;
using BSK.PS2;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CaesarCipher matrixSwap = new CaesarCipher();
            string encrypted = matrixSwap.Encrypt("CRYPTOGRAPHY");
            Console.WriteLine(encrypted);
            Console.WriteLine(matrixSwap.Decrypt(encrypted));

            Console.ReadKey();
        }
    }
}

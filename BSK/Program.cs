using System;
using BSK.PS2;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatrixSwap railFence = new MatrixSwap(4, 3, 1, 4, 2);
            string encrypted = railFence.Encrypt(input);
            Console.WriteLine(encrypted);
            Console.WriteLine(railFence.Decrypt(encrypted));
            Console.ReadKey();
        }
    }
}

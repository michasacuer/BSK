using System;
using BSK.PS2;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatrixSwap matrixSwap = new MatrixSwap(5, 3, 4, 1, 5, 2);
            Console.WriteLine(matrixSwap.Encrypt(input));
            Console.ReadKey();
        }
    }
}

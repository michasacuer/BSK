using System;
using BSK.PS2;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Vigenere vigenere = new Vigenere("break");
            Console.WriteLine(vigenere.Encrypt(input));
            Console.ReadKey();
        }
    }
}

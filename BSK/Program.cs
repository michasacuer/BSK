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
            string encrypted = vigenere.Encrypt("cryptography");
            Console.WriteLine(encrypted);
            Console.WriteLine(vigenere.Decrypt(encrypted));

            Console.ReadKey();
        }
    }
}

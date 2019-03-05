using System;
using BSK.PS2;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            RailFence railFence = new RailFence(3);
            Console.WriteLine(railFence.Encrypt(input));
            Console.ReadKey();
        }
    }
}

using BSK.PS2;
using System;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixSwapString2b matrixSwap = new MatrixSwapString2b("ROWERJESTSPOKO");
            string e = matrixSwap.Encrypt("NAM STRZELAC NIE KAZANO WSTAPILEM NA DZIALO TYSIAC ARMAT GRZMIALO I BYLO FAJNIE");
            Console.WriteLine(e);
            Console.WriteLine(matrixSwap.Decrypt(e));
            Console.ReadKey();
        }
    }
}

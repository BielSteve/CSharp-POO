using System;

namespace Nullable___Coalescência_nula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable - Coalescência nula
            //Biel Steve


            double? x = null;
            double? y = 10.0;

            // se o x tiver valor nulo ele vai jogar o 5.0 na variavel a
            double a = x ?? 5.0;
            // se o y tiver valor nulo ele vai jogar o 5.0 na variavel b
            double b = y ?? 5.0;

            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}

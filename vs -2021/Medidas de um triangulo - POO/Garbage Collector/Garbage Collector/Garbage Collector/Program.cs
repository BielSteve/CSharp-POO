using System;

namespace Garbage_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            //Garbage Collector
            //Biel Steve
            Product p = new Product("TV", 900.0, 1);

            Console.WriteLine(p.nome);
        }
    }
}

using System;
using System.Globalization;

namespace Retangulo___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retangulo - POO
            //Biel Steve

            Retangulo r = new Retangulo();


            Console.WriteLine("Entre a Largura e a Altura do retângulo: ");
            string[] s = Console.ReadLine().Split(' ');
            r.largura = double.Parse(s[0], CultureInfo.InvariantCulture);
            r.altura = double.Parse(s[1], CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Area: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();





        }
    }
}

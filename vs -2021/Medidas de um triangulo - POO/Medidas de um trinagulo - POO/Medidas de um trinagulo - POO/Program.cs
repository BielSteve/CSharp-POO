using System;
using System.Globalization;

namespace Medidas_de_um_trinagulo___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medidas de um triangulo - POO
            //Biel Steve

            //Criando variaveis do tipo Triangulo, que é a classe
            Triangulo x, y;

            //instanciando a classe
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triangulo X  : ");
            string[] s = Console.ReadLine().Split(' ');
            x.A = double.Parse(s[0], CultureInfo.InvariantCulture);
            x.B = double.Parse(s[1], CultureInfo.InvariantCulture);
            x.C = double.Parse(s[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y  : ");
            s = Console.ReadLine().Split(' ');
            y.A = double.Parse(s[0], CultureInfo.InvariantCulture);
            y.B = double.Parse(s[1], CultureInfo.InvariantCulture);
            y.C = double.Parse(s[2], CultureInfo.InvariantCulture);


            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area X");
            }
            else
            {
                Console.WriteLine("Maior area Y");
            }

            Console.ReadLine();
        }
    }
}

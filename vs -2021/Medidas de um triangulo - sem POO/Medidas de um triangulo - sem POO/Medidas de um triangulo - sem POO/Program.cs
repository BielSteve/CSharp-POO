using System;
using System.Globalization;

namespace Medidas_de_um_triangulo___sem_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medidas de um triangulo - sem POO
            //Biel Steve

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X  : ");
            string[] s = Console.ReadLine().Split(' ');
            xA = double.Parse(s[0], CultureInfo.InvariantCulture);
            xB = double.Parse(s[1], CultureInfo.InvariantCulture);
            xC = double.Parse(s[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y  : ");
            s = Console.ReadLine().Split(' ');
            yA = double.Parse(s[0], CultureInfo.InvariantCulture);
            yB = double.Parse(s[1], CultureInfo.InvariantCulture);
            yC = double.Parse(s[2], CultureInfo.InvariantCulture);


            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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

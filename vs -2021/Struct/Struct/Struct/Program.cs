using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct
            //Biel Steve

            //podemos iniciar um struct apenas declarando os valores da variavel
            Point p;
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);
            //ou podemos iniciar um struct instanciando a variavel p
            p = new Point();
            Console.WriteLine(p);

        }
    }
}

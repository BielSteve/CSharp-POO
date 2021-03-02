using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Biel Steve
            ///Nullable

            double? x = null;
            double? y = 10.0;


            //Pega o valor do X ou  então se o valor não existir pega o valor padrão do tipo da variavel X(double) que é 0
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //vai dizer se dentro da variavel x existe algum valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //precisa de valor
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }




        }
    }
}

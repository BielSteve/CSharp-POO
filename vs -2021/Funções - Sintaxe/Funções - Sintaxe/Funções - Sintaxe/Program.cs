using System;

namespace Funções___Sintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funções - Sintaxe
            //Biel Steve

            int n1, n2, n3;

            Console.WriteLine("Digite 3 valores: ");
            string[] s = Console.ReadLine().Split(' ');
            n1 = int.Parse(s[0]);
            n2 = int.Parse(s[1]);
            n3 = int.Parse(s[2]);

            int resultado = Maior(n1, n2, n3);


            Console.WriteLine("Resultado : " + resultado);
            Console.ReadLine();


        }

        static int Maior(int a, int b, int c)
        {
            int maior = 0;

            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }
    }
}

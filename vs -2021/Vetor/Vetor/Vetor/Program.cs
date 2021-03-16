using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor
            //Biel Steve

            int n;



            Console.WriteLine("Digite uma quantidade :");
            n = int.Parse(Console.ReadLine());
            double[] vetor = new double[n];


            for (int i = 0; i < n; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double media = 0.0;

            for (int i = 0; i < n; i++)
            {
                media = media + vetor[i];
            }

            double resul = media / n;
            Console.WriteLine("A media é : " + resul.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Globalization;

namespace Vetor_do_tipo_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetor do tipo Classe 
            //Biel Steve

            Console.WriteLine("Digite a quantidade :");
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            Console.WriteLine("Digite o nome e o preço : ");
            for (int i=0; i<n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Product { Name = name, Price = price };
            }
            double soma = 0.0;

            for (int i = 0; i<n; i++)   
            {
                soma = soma + vet[i].Price;
            }
            double media = soma / n;

            Console.WriteLine("Preço médio igual a: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}

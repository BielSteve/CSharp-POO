using System;

namespace Exercicio_vetores_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio(vetores)
            //Biel Steve

            Console.WriteLine("Quantos quartos vão ser alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] vet = new Aluguel[10];

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vet[quarto] = new Aluguel (nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i= 0; i<10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(i + " : " + vet[i]);
                }
            }

        }
    }
}

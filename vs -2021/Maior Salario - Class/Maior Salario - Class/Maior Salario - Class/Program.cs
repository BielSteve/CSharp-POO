 using System;
using System.Globalization;

namespace Maior_Salario___Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maior Salario - Class
            //Biel Steve

            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro Funcionario");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario : ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo Funcionario");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario : ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("Salario medio: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}

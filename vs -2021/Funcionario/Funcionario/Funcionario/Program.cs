using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcionario
            //Biel Steve

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            
            Console.Write("Funcionario: "+f);
            Console.WriteLine();

            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double por = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(por);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + f);






        }
    }
}

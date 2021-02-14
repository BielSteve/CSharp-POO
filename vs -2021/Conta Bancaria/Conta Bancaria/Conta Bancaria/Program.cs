using System;
using System.Globalization;

namespace Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conta Bancaria
            //Biel Steve

            ContaBancaria c;
            string respota;

            Console.Write("Entre com número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da Conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)");
            respota = Console.ReadLine();
            if (respota == "s" || respota == "S")
            {
                Console.Write("Entre com o Valor de deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c = new ContaBancaria(numero, titular, saldo);
            }
            else
            {
                c = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine("Entre com um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            c.Deposito(quantia);

            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(quantia);

            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(c);

        }
    }
}

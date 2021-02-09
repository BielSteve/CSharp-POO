using System;
using System.Globalization;

namespace Cotação_do_dolar___Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cotação do dolar - Estatico
            //Biel Steve

            Console.Write("Digite qual sé a cotação do dolar: ");
            double cota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar:");
            double comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //nome da classe, seguido pelo nome do metodo estatico
            double resultado = ConversorDeMoeda.DolarParaReal(comprar, cota);

            Console.WriteLine("Valor a ser pago em reais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

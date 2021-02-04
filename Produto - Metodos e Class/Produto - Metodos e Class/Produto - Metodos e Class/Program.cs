using System;
using System.Globalization;

namespace Produto___Metodos_e_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto - Metodos e Class
            //Biel Steve

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
        }
    }
}

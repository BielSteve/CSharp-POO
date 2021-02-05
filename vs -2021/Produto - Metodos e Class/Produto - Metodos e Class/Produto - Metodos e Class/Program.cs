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
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos: ");
            int remover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(remover);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.ReadLine();

        }
    }
}

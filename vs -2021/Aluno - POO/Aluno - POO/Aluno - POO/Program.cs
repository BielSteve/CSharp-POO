using System;
using System.Globalization;

namespace Aluno___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aluno - POO
            //Biel SSteve

            Aluno n = new Aluno();

            Console.Write("Nome do Aluno : ");
            n.Nome = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            string[] s = Console.ReadLine().Split(' ');
            n.N1 = double.Parse(s[0], CultureInfo.InvariantCulture);
            n.N2 = double.Parse(s[1], CultureInfo.InvariantCulture);
            n.N3 = double.Parse(s[2], CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: "+n.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (n.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + n.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

            Console.ReadLine();
        }
    }
}

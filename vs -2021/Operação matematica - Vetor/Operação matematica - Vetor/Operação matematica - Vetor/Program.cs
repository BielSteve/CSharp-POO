using System;

namespace Operação_matematica___Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operação matematica - Vetor
            //Biel Steve

            //Aqui estamos criando e instanciando os vetores, e ja acrescentando valores para calculo
            int s1 = Calculator.Soma(new int[] { 2, 3 });
            int s2 = Calculator.Soma(new int[] { 2, 3, 10 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadLine();


        }
    }
}

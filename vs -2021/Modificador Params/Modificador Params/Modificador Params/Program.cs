using System;

namespace Operação_matematica___Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operação matematica - Vetor
            //Biel Steve

            //Aqui estamos mando para em parenteses os numeros para calculo na classe Calculator, que ja recebe diretamente
            //no vetor numero, com a função params
            int s1 = Calculator.Soma(2, 3 );
            int s2 = Calculator.Soma(2, 3, 10);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Operação_matematica___Vetor
{
    class Calculator
    {

        public static int Soma(int[] numeros)
        {
            int soma = 0;
            //Length pega o tamanho do vetor automaticamente 
            for (int i=0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            return soma;
        }



    }
}

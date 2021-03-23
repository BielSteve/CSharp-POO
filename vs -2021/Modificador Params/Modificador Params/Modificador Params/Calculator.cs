using System;
using System.Collections.Generic;
using System.Text;

namespace Operação_matematica___Vetor
{
    class Calculator
    {
        //palavra params vai avisar para o compilador que você quer uma função que possa receber uma quantia variavel de valores
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            //Length pega o tamanho do vetor automaticamente 
            for (int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            return soma;
        }



    }
}

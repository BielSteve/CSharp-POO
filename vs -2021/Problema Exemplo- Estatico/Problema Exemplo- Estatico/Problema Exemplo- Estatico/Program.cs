﻿using System;
using System.Globalization;

namespace Problema_Exemplo__Estatico
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //Problema Exemplo- Estatico
            //Biel Steve

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double circ = Calculadora.Circunferencia(raio);
            double volume =  Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }

        

    }
}

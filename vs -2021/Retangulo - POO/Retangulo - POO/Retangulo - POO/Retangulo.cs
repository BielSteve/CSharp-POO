using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Retangulo___POO
{
    class Retangulo
    {
        //esses são atributos
        public double largura;
        public double altura;

        //esses são metodos
        public double Area()
        {
            double area = largura * altura;
            return area;
        }
        public double Perimetro()
        {
            double perimetro = (largura + altura) * 2.0;
            return perimetro;
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt(largura * largura + altura * altura);
            return diagonal;
        }
    }
}

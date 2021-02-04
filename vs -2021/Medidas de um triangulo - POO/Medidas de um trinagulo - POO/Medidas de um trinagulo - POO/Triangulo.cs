using System;
using System.Collections.Generic;
using System.Text;

namespace Medidas_de_um_trinagulo___POO
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;


        //metodo
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

    }
}

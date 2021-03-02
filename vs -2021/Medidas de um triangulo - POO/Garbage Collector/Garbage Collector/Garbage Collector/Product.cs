using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Garbage_Collector
{
    class Product
    {
        public string nome;
        public double valor;
        public int unidade;

        public Product(string nome, double valor, int unidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.unidade = unidade;
        }
        public void method1()
        {
            Product p = method2();
            Console.WriteLine(p.nome);
        }
        Product method2()
        {
            Product prod = new Product("TV", 900.0, 1);
            return prod;
        }
    }
}

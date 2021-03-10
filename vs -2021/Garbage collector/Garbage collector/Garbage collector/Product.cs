using System;
using System.Collections.Generic;
using System.Text;

namespace Garbage_collector
{
    class Product
    {
        public string name;
        public double preco;
        public int qtda;

        public Product(string name, double preco, int qtda)
        {
            this.name = name;
            this.preco = preco;
            this.qtda = qtda;
        }

        public string method1()
        {
            Product p = method2();
            string prod = p.name;
            return prod;
            
        }

        public Product method2()
        {
            Product prod = new Product("TV", 900.00, 0);
            return prod;
        }
        public override string ToString()
        {
            return name+" " + preco + " " + qtda;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Produto___Metodos_e_Class
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //metodo
        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }
    }
}

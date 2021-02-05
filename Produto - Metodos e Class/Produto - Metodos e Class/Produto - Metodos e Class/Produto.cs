using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2",CultureInfo.InvariantCulture)+ " ,"+Quantidade+" unidades, Total: $ " 
                +ValorTotalEstoque().ToString("F2" , CultureInfo.InvariantCulture);
        }
    }
}

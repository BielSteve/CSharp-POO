using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Trabalhando_com_a_palavra_This
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Isso é um construtor, ele sempre tera o mesmo nome da classe
        //Nesse caso estamos obrigando ao usuario ter que digitar sempre esses valores de entrada
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            //Nome = nome;
            //Preco = preco;
            Quantidade = quantidade;
        }
        //Criando mais um construtor com parametros diferentes, nesse caso gera sobrecarga
        //this serve tanto para diferenciar atributo de classe de variaveis locais
        //e referenciar um contrutor dentro de outro
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
            
        }
        //Também é possivel criar um construtor vazio
        public Produto()
        {
            this.Quantidade = 10;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


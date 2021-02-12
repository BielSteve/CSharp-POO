using System.Globalization;
namespace Encapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Isso é um construtor, ele sempre tera o mesmo nome da classe
        //Nesse caso estamos obrigando ao usuario ter que digitar sempre esses valores de entrada
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        //Criando mais um construtor com parametros diferentes, nesse caso gera sobrecarga
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }
        //Também é possivel criar um construtor vazio
        public Produto()
        {
        }

        //Encapsulamento //get = pegar // set = definir
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
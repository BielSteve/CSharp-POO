using System.Globalization;
namespace Properties
{
    class Produto
    {
        private string _nome;
        //Conceito de auto properties, se não haver logica especifica podemos fazer dessa maneira
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Isso é um construtor, ele sempre tera o mesmo nome da classe
        //Nesse caso estamos obrigando ao usuario ter que digitar sempre esses valores de entrada
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Criando mais um construtor com parametros diferentes, nesse caso gera sobrecarga
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        //Também é possivel criar um construtor vazio
        public Produto()
        {
        }

        //Properties
        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1)
                {
                    _nome = value;
                } 
            }
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
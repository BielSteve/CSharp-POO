using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_vetores_
{
    class Aluguel
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        //Construtor
        public Aluguel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modificadores_de_acesso.Models
{
    public class Pessoa
    {
        private string nome;

        public string Nome
        {
            get => nome;

            set => nome = (value != "") ? nome = value : throw new ArgumentException("O nome não pode ser vazio");
        }

        protected string sobrenome;

        public string Sobrenome
        {
            get => sobrenome;

            set => sobrenome = (value != "") ? sobrenome = value : throw new ArgumentException("O sobrenome não pode ser vazio");
        }
        public int Idade;

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} {Sobrenome}, tenho {Idade} anos");
        }

    }
}
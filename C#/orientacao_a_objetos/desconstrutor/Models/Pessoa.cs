using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desconstrutor.Models
{
    //Exemplo de classe com Deconstruct
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;

        }

        public Pessoa(string nome, string sobrenome, int idade)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Idade = idade;

        }

        //Exemplo de Deconstruct
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {

            get
            {
                return _idade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade deve ser maior que 0");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {NomeCompleto}, tenho {Idade} anos.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace get_set.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            //Body expression

            // get => _nome.ToUpper();

            get
            {
                return _nome.ToUpper();
            }

            //Body expression

            //set => _nome = (value != "") ? _nome = value : throw new ArgumentException("O nome não pode ser vazio");

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
            //Body expression

            // get => _idade;

            get
            {
                return _idade;
            }

            //Body expression

            //set => _nome = (value != "") ? _nome = value : throw new ArgumentException("O nome não pode ser vazio");

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
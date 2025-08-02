using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace construtores.Models
{
    public class Pessoa
    {

        //Pode-se adicionar quantos construtores fores necessários

        //Construtor sem parâmetros (serão adicionados depois)
        public Pessoa()
        {
 
        }

        //Construtor com nome e sobrenome
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome; //Atribui o parãmetro nome no atributo nome
            this.Sobrenome = sobrenome; //Atribui o parãmetro sobrenome no atributo sobrenome

        }

        //Construtor com nome, sobrenome e idade
        public Pessoa(string nome, string sobrenome, int idade)
        {
            this.Nome = nome; //Atribui o parãmetro nome no atributo nome
            this.Sobrenome = sobrenome; //Atribui o parãmetro sobrenome no atributo sobrenome
            this.Idade = idade; //Atribui o parãmetro idade no atributo idade

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
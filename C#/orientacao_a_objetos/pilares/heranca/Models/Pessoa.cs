using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        //Exemplo de construtor de classe pai (esse construtor será exigido nas classes filhas)
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos");
        }
    }
}
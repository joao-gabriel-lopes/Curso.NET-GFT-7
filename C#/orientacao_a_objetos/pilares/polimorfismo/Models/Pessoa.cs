using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polimorfismo.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() //VIRTUAL permite sobrescrever métodos
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos");
        }
    }
}
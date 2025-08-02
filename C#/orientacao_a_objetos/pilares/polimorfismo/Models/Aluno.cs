using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() //OVERRIDE permite sobrescrever métodos
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos. Sou um aluno nota {Nota}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_selada.Models
{
    //Exemplo de classe selada
    // public sealed class Professor : Pessoa
    // {
    //     public decimal Salario { get; set; }

    //     public override void Apresentar()
    //     {
    //         Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos. Sou um professor e ganho {Salario}");
    //     }
    // }

    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        //Exemplo de método selado
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos. Sou um professor e ganho {Salario}");
        }
    }
}
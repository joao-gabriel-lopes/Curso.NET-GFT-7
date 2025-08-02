using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo.common.Models
{
    public class Pessoa //PascalCase
    {
        public string Nome { get; set; } //PascalCase
        public int Idade { get; set; } //PascalCase
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; } //PascalCase

        public void Apresentar() //PascalCase
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_selada.Models
{
    public class Diretor : Professor //Não é possívvel herdar de uma classe selada
    {
        public void Apresentar() //Um método selado herdado não pode ser modificado
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos. Sou um professor e ganho {Salario}");
        }
    }
}
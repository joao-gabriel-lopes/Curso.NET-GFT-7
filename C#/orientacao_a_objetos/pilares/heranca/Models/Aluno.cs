using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Models
{
    public class Aluno : Pessoa //Só é possível herdar uma classe
    {
        public Aluno()
        {
            
        }

        //Exemplo de construtor de classe filho (esse construtor é herdado da classe pai)
        public Aluno(string nome) : base(nome)
        {

        }

        public double Nota { get; set; }
    }
}
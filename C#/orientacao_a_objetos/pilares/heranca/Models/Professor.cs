using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Models
{
    public class Professor : Pessoa //Só é possível herdar uma classe
    {
        public Professor()
        {
            
        }

        //Exemplo de construtor de classe filho (esse construtor é herdado da classe pai)
        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }
    }
}
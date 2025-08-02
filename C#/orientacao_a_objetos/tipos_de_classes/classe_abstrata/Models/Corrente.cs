using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_abstrata.Models
{
    public class Corrente : Conta
    {
        //Exemplo de classe filha de classe abstrata
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}
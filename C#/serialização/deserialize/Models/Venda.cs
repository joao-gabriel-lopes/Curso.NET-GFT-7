using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace deserialize.Models
{
    public class Venda
    {
        public int Id { get; set; }

        //[JsonProperty("Nome_Produto")] //Exemplo de atributo
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime Data { get; set; }
    }
}
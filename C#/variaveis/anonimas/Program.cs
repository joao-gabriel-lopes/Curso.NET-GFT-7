using System.Runtime.InteropServices.Marshalling;
using anonimas.Models;
using Newtonsoft.Json;

//Tipos anônimos permitem encapsular propriedades somente leitura

//Exemplo de variável anônima

var tipoAnonimo = new { Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80 };

Console.WriteLine($"Nome: {tipoAnonimo.Nome}");
Console.WriteLine($"Sobrenome: {tipoAnonimo.Sobrenome}");
Console.WriteLine($"Altura: {tipoAnonimo.Altura}");


//Exemplo de uso de tipo anônimo em uma coleção

string conteudoArquivo = File.ReadAllText("Files/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}
using System.Text.Json.Serialization;
using deserialize.Models;
using Newtonsoft.Json;

//Deserialização permite converter dados em um objeto

//deserializando uma lista de vendas

string conteudoArquivo = File.ReadAllText("Files/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.Data}");
}

//Deserializando um objeto utilizando atributos

// string conteudoArquivo2 = File.ReadAllText("Files/venda.json");

// List<Venda> listaVenda2 = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda2)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.Data}");
// }
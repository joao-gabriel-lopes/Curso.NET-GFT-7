using Newtonsoft.Json;
using nullable.Models;

//Tipos nullable permitem que a variável represente o seu tipo e o valor null

//Exemplo de variável nullable

bool? desejaReceberEmail = null;

if (desejaReceberEmail.HasValue)
{
    if (desejaReceberEmail.Value)
    {
        Console.WriteLine("O usuário optou por receber email");
    }
    else
    {
        Console.WriteLine("O usuário optou por não receber email");
    }
}
else
{
    Console.WriteLine("O usuário não respondeu a pesquisa");
}

//Exemplo de lista com propriedade nullable

string conteudoArquivo = File.ReadAllText("Files/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.Data}, {(venda.Desconto.HasValue ? $"Desconto de {venda.Desconto}" : "")}");
}
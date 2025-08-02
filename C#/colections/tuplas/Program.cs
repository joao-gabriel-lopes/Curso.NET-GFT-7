using System.Runtime.InteropServices;
using tuplas.Models;

//Tuplas permitem agrupar vários elementos de dados em uma estrutura de dados leve.

//Sintaxe em variável

(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Leonardo", "Buta", 1.80M); //Sintaxe abreviada
//ValueTuple<int, string, string, decimal> outraTupla = (1, "Leonardo", "Buta", 1.80M); //Sintaxe ValueTuple
//var outraTupla2 = Tuple.Create(1, "Leonardo", "Buta", 1.80M); //Sintaxe Create

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");



//Sintaxe em método

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, QuantidadeLinhas) = arquivo.LerArquivo("Files/teste.txt");

if (sucesso)
{
    Console.WriteLine("Quantidade de linhas do arquivo: " + QuantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

//Como descartar uma informação da tupla

LeituraArquivo arquivo2 = new LeituraArquivo();

//O (_) permite descartar uma variável da tupla
var (sucesso2, linhasArquivo2, _) = arquivo.LerArquivo("Files/teste.txt");

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo: " + QuantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
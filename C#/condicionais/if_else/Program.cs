int quantidadeEmEstoque = 10;
int quantidadeCompra = 3;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque. ");
}

//IF e ELSE ternários
//variável = (condição) ? ValorVerdadeiro :  ValorFalso;

int hora = 20;
string resultado = (hora < 18) ? "Bom dia." : "Boa tarde.";
Console.WriteLine(resultado);
using System.Linq.Expressions;
using exception.Models;

//O bloco THROW dispara um erro proposital no código, com a intenção de debug ou demonstrar um erro no código
ExemploExcecao exemplo = new ExemploExcecao();

try
{
    exemplo.Metodo1();
}
catch (Exception e)
{
    Console.WriteLine(e.StackTrace);
    Console.WriteLine(e);
}
//Tipo dynamic permite que uma variável assuma um tipo correspondente ao se valor dinamicamente

//Exemplo de variável dinâmica

dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "Texto";

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

//Operador ternário permite uma sintaxe if/else simples e rápida, contudo com limitação de uma condição

int numero = 10;
bool ePar = false;

//IF Ternário
ePar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ePar ? "par" : "ímpar"));

//IF comum

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}

using extension_method.Models;

//Métodos extensão permitem criar um método específico para um tipo de dados

//Verificando se o número é par ou ímpar utilizando if ternário

int numero = 10;
bool ePar = false;

ePar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ePar ? "par" : "ímpar"));


//Verificando se o número é par ou ímpar utilizando o método extensão

int numero1 = 15;
ePar = numero1.EPar();

Console.WriteLine($"O número {numero1} é " + (ePar ? "par" : "ímpar"));

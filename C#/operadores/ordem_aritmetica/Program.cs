//O C# utiliza a ordem aritmética para a execução operadores

//Sendo que os operadores / e * serão executados primeiro

int a = 5 + 10 / 5; //Aqui a divisão ocorreu primeiro e após ocorreu a soma

Console.WriteLine(a);

//Podemos usar o () para corrigir isso

int b = (5 + 10) / 5; //Aqui a soma ocorreu e após ocorreu a divisão

Console.WriteLine(b);
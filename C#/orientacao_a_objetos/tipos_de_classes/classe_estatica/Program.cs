using classe_estatica.Models;

//Uma classe estática permite a utilização de seus métodos sem a necessidade de instanciá-la, porém ela não pode ser instancida e ela só permite atributos e métodos estáticos

//Calculadora calc = new Calculadora(); //Não é possível instanciar uma classe eatática

//Utilizando os métodos estáticos

Console.WriteLine($"Soma: {Calculadora.Somar(2, 7)}");
Console.WriteLine($"Subtração: {Calculadora.Subtrair(8, 4)}");
Console.WriteLine($"Multiplicação: {Calculadora.Multiplicar(4, 7)}");
Console.WriteLine($"Divisão: {Calculadora.Dividir(8, 2)}");

//Modificando e utilizando atributos estáticos

Calculadora.Modelo = "Científica";
Console.WriteLine($"Modelo da calculadora: {Calculadora.Modelo}");

Calculadora.NumeroDigitos = 10;
Console.WriteLine($"Número de dígitos da calculadora: {Calculadora.NumeroDigitos}");
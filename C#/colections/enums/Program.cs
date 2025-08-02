using enums.Models;

//ENUMS são uma classe que representa um grupo de variáveis constantes (não podem ser modificadas)

//Acessando os itens de um ENUM

Nivel exemplo = Nivel.Medio;

Console.WriteLine(exemplo);

//Recuperando um valor inteiro de um ENUM

int num = (int)Nivel.Alto;

Console.WriteLine($"Número do valor alto: {num}");
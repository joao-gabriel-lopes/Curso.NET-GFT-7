using classe_generica.Models;

//Classes genéricas encapsulam operações que não são específicas de um determinado tipo de dados

//Utilizando a classe genérica para criar um array de inteiros

MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(5);

Console.WriteLine(arrayInteiro[0]);

//Utilizando a classe genérica para criar um array de strings

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Texto");

Console.WriteLine(arrayString[0]);
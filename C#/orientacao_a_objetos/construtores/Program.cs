using construtores.Models;

//Estrutura sem construtor

// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "José";
// pessoa1.Sobrenome = "Queirós";
// pessoa1.Idade = 19;

// Pessoa pessoa2 = new Pessoa();
// pessoa2.Nome = "Murilo";
// pessoa2.Sobrenome = "Pascoal";
// pessoa2.Idade = 25;

// pessoa1.Apresentar();
// pessoa2.Apresentar();

//Estrutura com construtor

Pessoa pessoa1 = new Pessoa(nome: "José", sobrenome: "Queirós", 19);
Pessoa pessoa2 = new Pessoa("Murilo", "Pascoal", 25);

pessoa1.Apresentar();
pessoa2.Apresentar();
using desconstrutor.Models;

//Deconstruct permite desconstruir uma instância em variáveis separadas

Pessoa pessoa1 = new Pessoa("Leonardo", "Buta");

(string nome, string sobrenome) = pessoa1;

Console.WriteLine($"{nome} {sobrenome}");

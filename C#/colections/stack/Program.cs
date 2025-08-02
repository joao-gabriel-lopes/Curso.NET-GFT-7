//Numa pilha o primeiro a entrar, será o último a sair e o último a entrar será o primeiro a sair

//Criando uma pilha de inteiros

Stack<int> pilha = new Stack<int>();


//Adicionando elementos no início da pilha

pilha.Push(62);
pilha.Push(37);
pilha.Push(15);
pilha.Push(93);


//Percorrendo uma pilha com FOREACH

foreach (int item in pilha)
{
    Console.WriteLine(item);
}


//Retirando o elemento que está no início da pilha

Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");


//Contando quantos elementos tem na pilha

Console.WriteLine(pilha.Count);


//Pesquisando se um elemento está na pilha

Console.WriteLine(pilha.Contains(15));


//Vendo o primeiro da pilha

Console.WriteLine(pilha.Peek());


//Limpando a pilha

//pilha.Clear();

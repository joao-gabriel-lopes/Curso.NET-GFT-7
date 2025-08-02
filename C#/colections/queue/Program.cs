//Numa fila o primeiro a entrar, será o primeiro a sair e o último a entrar será o último a sair

//Criando uma fila de inteiros

Queue<int> fila = new Queue<int>();


//Adicionando elementos no fim da fila

fila.Enqueue(25);
fila.Enqueue(74);
fila.Enqueue(18);
fila.Enqueue(58);


//Percorrendo uma fila com FOREACH

foreach (int item in fila)
{
    Console.WriteLine(item);
}


//Retirando o elemento que está no início da fila

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");


//Contando quantos elementos tem na fila

Console.WriteLine(fila.Count);


//Pesquisando se um elemento está na fila

Console.WriteLine(fila.Contains(25));


//Vendo o primeiro da fila

Console.WriteLine(fila.Peek());


//Limpando a fila

//fila.Clear();

//Declarando uma matriz

int[,] numerosMatriz = { { 1, 4, 2 }, { 3, 6, 8 } };

//Selecionando um valor específico

Console.WriteLine(numerosMatriz[0, 2]);

//Mudando um valor específico

numerosMatriz[0, 0] = 5;
Console.WriteLine(numerosMatriz[0, 0]);

//Percorrendo valores de uma matriz

for (int i = 0; i < numerosMatriz.GetLength(0); i++) 
{ 
  for (int j = 0; j < numerosMatriz.GetLength(1); j++) 
  { 
    Console.WriteLine(numerosMatriz[i, j]); 
  } 
}  
int[] arrayInteiros = new int[3]; //Array com três posições

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros = [3] = 20; //Posição inválida, pois o array só possui três posições

//Percorrendo o array com FOR

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição N° {i}: {arrayInteiros[i]}");
}

//Percorrendo o array com FOREACH

int contador = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contador}: {valor}");
    contador++;
}

//Redimensionando um array

//Cria um array com um novo tamanho e substitui o array antigo
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); //Dobrando a capacidade do array

//Cria um novo array, com os elementos do array antigo
// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);


//OUTRAS MANEIRAS DE DECLARAR UM ARRAY


//Array com tamanho específico e valores definidos
string[] array1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

//array1[4] = "Ferrari"; //Posição inválida, pois o array só possui três posições

//Array com valores definidos e tamanho indefinido
string[] array2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

//array2[4] = "Ferrari"; //Posição inválida, pois o array só possui três posições

//Array com valores definidos e tamanho indefinido, sem o NEW
string[] array3 = { "Volvo", "BMW", "Ford", "Mazda" };

//array3[4] = "Ferrari"; //Posição inválida, pois o array só possui três posições

//Array sem valores
string[] array4;

//Adicionando valores usando NEW
array4 = new string[] {"Volvo", "BMW", "Ford"};
       
//Adicionando valores sem NEW (irá causar um erro)
//array4 = {"Volvo", "BMW", "Ford"};
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

int contador = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição N° {contador}: {valor}");
    contador++;
}
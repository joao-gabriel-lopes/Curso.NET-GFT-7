int numero = 5;
int contador = 1;

while (contador <= 10)
{
    Console.WriteLine($"{contador}º execução: {numero} X {contador} = {numero * contador}");

    //Pausa o loop por completo
    // if (contador == 5)
    // {
    //     break;
    // }

    //Passa para a próxima iteração
    // if (i == 4)
    // {
    //     continue;
    // }

    contador++;
}
//Caso de exceção genérica (representa qualquer tipo de exceção)

try
{
    string[] linhas = File.ReadAllLines("Files/teste.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}

//Exemplo de exceção genérica
catch (Exception e)
{
    Console.WriteLine($"Ocorreu um erro: {e.Message}");
}



//Caso de exceção específica (representa um tipo específico de exceção)

try
{
    string[] linhas = File.ReadAllLines("Files/teste.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
//Exemplo de exceção específica (caso o arquivo não seja encontrado)
catch (FileNotFoundException e)
{
    Console.WriteLine($"Ocorreu um erro. Arquivo não encontrado. {e.Message}");
}
//Exemplo de exceção específica (caso a pasta não seja encontrada) 
catch (DirectoryNotFoundException e)
{
    Console.WriteLine($"Ocorreu um erro. Pasta não encontrada. {e.Message}");
}

//Exemplo de exceção genérica
catch (Exception e)
{
    Console.WriteLine($"Ocorreu um erro: {e.Message}");
}
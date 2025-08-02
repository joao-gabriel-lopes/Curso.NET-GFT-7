
//Permite o encapsumento do código em caso de um possível erro
try
{
    string[] linhas = File.ReadAllLines("Files/tete.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
//Em caso de erro, captura o erro e executa o código dentro do bloco
catch (Exception e)
{
    Console.WriteLine($"Ocorreu um erro: {e.Message}");
}

Console.WriteLine("Chegou até aqui");
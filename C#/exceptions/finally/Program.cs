//O bloco FINALLY será executado independentemente se houver um erro ou não

try
{
    string[] linhas = File.ReadAllLines("Files/teste.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception e)
{
    Console.WriteLine($"Ocorreu um erro: {e.Message}");
}
//exemplo de FINALLY
finally
{
    Console.WriteLine("Chegou até o finally");
}
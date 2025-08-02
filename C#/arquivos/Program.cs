using System.Xml;

string texto = "Um texto de exemplo";

string[] linhas = File.ReadAllLines("Files/teste.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}

//AppendAllText() (Insere texto no final de um arquivo)

//File.AppendAllText("Files/teste.txt", texto);


//Copy() (Copia um arquivo)

//File.Copy("Files/teste.txt", "Files/teste2.txt");


//Create() (Cria ou sobrescreve um arquivo)

//File.Create("Files/teste3.txt");


//Delete() (Deleta um arquivo)

// File.Delete("teste3.txt");


//Exists() (Testa se o arquivo existe)

//Console.WriteLine(File.Exists("Files/teste.txt"));


//ReadAllText() (Lê o conteúdo de um texto)

//Console.WriteLine(File.ReadAllText("Files/teste.txt"));


//Replace()	(Substitui o conteúdo de um arquivo pelo conteúdo de outro arquivo)

// File.Replace("Files/teste.txt", "Files/teste2.txt", "Files/teste.txt");


//WriteAllText() (Cria um novo arquivo e escreve conteúdo nele. Se o arquivo existir, ele será sobrescrito.)

//File.WriteAllText("Files/teste3.txt", texto);
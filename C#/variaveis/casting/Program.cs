//Casting com Convert

string palavra1 = "5";

int num1 = Convert.ToInt32(palavra1); //Transforma valores null em 0

Console.WriteLine(num1);

//Casting com Parse

string palavra2 = "5";

int num2 = int.Parse(palavra2); //Causa um erro com valores null

Console.WriteLine(num2);


//Casting de maneira segura
string livro = "Senhor dos Anéis";

//int saida = 0;

int.TryParse(livro, out int saida);

Console.WriteLine(saida);


//Castings implícitos //Se o valor máximo do tipo da variável for menor que o valor máximo do tipo em que ela está sendo convertida, a conversão ocorre sem a necessidade de um casting explícito

int a = 5;
double b = a; //Valores double suportam valores int sem a necessidade de casting explícito

Console.WriteLine(b);

int c = 5;
long d = c; //Valores long suportam valores int sem a necessidade de casting explícito

Console.WriteLine(d);

short f = 5;
int e = f; //Valores int suportam valores short sem a necessidade de casting explícito

Console.WriteLine(f);
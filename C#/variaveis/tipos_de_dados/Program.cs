string apresentacao = "Olá, seja bem vindo"; //Série de caracteres

char letra = 'a'; //Caractere

int quantidade = 1; //-2347483648 a 2347483647

DateTime data = new DateTime(); //Tipo de data com diversos métodos, como AddDays e ToString("dd/MM/yy HHmm")

var dataAtual = DateTime.Now; //Retorna a data atual do dispositivo

object objeto = new object(); //Objeto

bool sim = true; //True ou False

byte byt = 5; //0 a 255

decimal dinheiro = 12.50M; //Poucas casa decimais

float preco = 7.99F; //Casas decimais médias

double altura = 1.80; //Muitas casas decimais

long longo = 252352452; //-9223372036854775808 a 9223372036854775807 

uint natural = 123; //0 a 4294967296

short curto = 15; //-32787 a 32767

ulong naturalLongo = 2757245278; //0 a 18446744073709551615

const int num = 15;
//myNum = 20; //irá causar um erro

Console.WriteLine("Valor string: " + apresentacao);
Console.WriteLine("Valor char: " + letra);
Console.WriteLine("Valor int: " + quantidade);
Console.WriteLine("Valor DateTime: " + data.ToString("dd/MM/yyyy"));
Console.WriteLine("Data atual: " + dataAtual);
Console.WriteLine("Valor object: " + objeto);
Console.WriteLine("Valor bool: " + sim);
Console.WriteLine("Valor byte: " + byt);
Console.WriteLine("Valor decimal: " + dinheiro);
Console.WriteLine("Valor float: " + preco);
Console.WriteLine("Valor double: " + altura);
Console.WriteLine("Valor long: " + longo);
Console.WriteLine("Valor uint: " + natural);
Console.WriteLine("Valor short: " + curto);
Console.WriteLine("Valor ulong: " + naturalLongo);
Console.WriteLine("Valor constante: " + num);
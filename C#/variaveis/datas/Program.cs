//Representa a hora atual do dispositivo
using System.Globalization;

DateTime data = DateTime.Now;

Console.WriteLine(data);

//Alterando o estilo que a data é mostrada

//(d) são os dias
//(M) são os meses
//(y) são os anos
//(H/h) são as horas (H mostra formato 24H, h mostra formato 12H)
//(m) são os minutos
//(s) são os segundos

Console.WriteLine(data.ToString("dd/MM/yyyy"));
Console.WriteLine(data.ToString("yyyy/MM/dd"));
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

//Mostrando apenas as horas

Console.WriteLine(data.ToShortDateString());

//Transformando uma string em data com PARSE

//Caso a string seja inválida um erro ocorrerá
string dataString = "25/04/2025 14:00";

DateTime data1 = DateTime.Parse(dataString);

Console.WriteLine(data1);

//Transformando uma string em data com TRYPARSEEXACT

string dataString2 = "14/10/2017 11:00";

bool sucesso = DateTime.TryParseExact(dataString2, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data2);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso: {data2}");
}
else
{
    Console.WriteLine($"{dataString2} não é uma data válida");
}
using serialize.Models;
using Newtonsoft.Json;

// Serialização permite converter uma estrutura de dados em outra e vice-versa.

//Serializando um objeto

DateTime dataAtual = DateTime.Now;

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

File.WriteAllText("Files/venda.json", serializado);

Console.WriteLine(serializado);

//Serializando uma coleção de objetos

List<Venda> listaVendas = new List<Venda>();

Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string listaSerializada = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Files/vendas.json", listaSerializada);

Console.WriteLine(listaSerializada);
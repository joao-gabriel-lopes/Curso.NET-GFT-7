//Um dicionário é uma coleção de valores com indicações únicas para cada um deles

//Criando um dictionary

Dictionary<string, string> estados = new Dictionary<string, string>();


//Adicionando valores em um dicionário

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("TO", "Tocantins");
estados.Add("MS", "Mato Grosso do Sul");
estados.Add("AC", "Acre");
//estados.Add("AC", "Acre2"); //Causará um erro, pois um elemento com essa chave já existe


//Percorrendo um dicionário com FOREACH

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


//Alterando valores em um dicionário

estados["SP"] = "São Bento";


//Removendo valores em um dicionário

Console.WriteLine($" {estados.Remove("AC")}");


//Pesquisando valores em um dicionário

Console.WriteLine($"Estado: {estados.ContainsValue("Minas Gerais")}");


//Pesquisando chaves em um dicionário

Console.WriteLine($"Sigla: {estados.ContainsKey("MG")}");


//Pegando uma lista das chaves de um dicionário

Console.WriteLine($"Chaves: {estados.Keys}");


//Pegando uma lista das valores de um dicionário

Console.WriteLine($"Valores: {estados.Values}");


//Limpando os valores e chaves de um dicionário

//estados.Clear();

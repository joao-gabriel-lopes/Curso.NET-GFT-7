using System.Globalization;

decimal dinheiro = 1582.40M;

//Configurando o número de casas decimais
Console.WriteLine(dinheiro.ToString("C5"));

//Configurando o número como porcentagem
double porcentagem = .3678;

Console.WriteLine(porcentagem.ToString("P"));

//Configurando o número de maneira personalizada
int numero = 823457;

Console.WriteLine(numero.ToString("##-##-##"));

//Modifica o valor adicionando a moeda correspondente as configurações do sistema
Console.WriteLine($"{dinheiro:c}");

//Modificando as configurações de local
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//Mostra o valor no formato dos Estados Unidos
Console.WriteLine($"{dinheiro:c}");

//Outra maneira de mudar o formato do dinheiro
Console.WriteLine(dinheiro.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
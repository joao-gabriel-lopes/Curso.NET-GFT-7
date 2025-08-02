//Operador OR (||)

bool eMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada negada!");
}

//Operador AND (&&)

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

//Operador NOT (!)

bool choveu = true;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}
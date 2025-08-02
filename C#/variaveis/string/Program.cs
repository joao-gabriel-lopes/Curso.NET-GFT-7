string texto = "Um texto para testes";

//Selecionando um elemento da string

char caractere = texto[0];

Console.WriteLine(caractere);

//Concatenação

string textoConcatenado = texto + " de concatenação";

Console.WriteLine(textoConcatenado);

//Interpolação

string textoInterpolado = $"{texto} de interpolação";

Console.WriteLine(textoInterpolado);

//LENGTH (retona o tamanho da string)

Console.WriteLine(texto.Length);

//ToUpper (retorna a string toda maiúscula)

Console.WriteLine(texto.ToUpper());

//ToLower (retorna a string toda minúscula)

Console.WriteLine(texto.ToLower());

//IndexOf (retorna o índice de um valor na string)

Console.WriteLine(texto.IndexOf("t"));

//Caracteres especiais

string exemplo = "Nós somos os vikings";

//O caractere (\') adiciona (') na string

Console.WriteLine(exemplo + " do \'norte\'");

//O caractere (\") adiciona (") na string

Console.WriteLine(exemplo + " do \"norte\"");

//O caractere (\\) adiciona (\) na string

Console.WriteLine(exemplo + " do \\norte\\");

//Outros atalhos úteis

//O caractere (\n) passa para a próxima linha

Console.WriteLine(exemplo + "\ndo norte");

//O caractere (\t) adiciona um espaço da tecla TAB na string

Console.WriteLine(exemplo + "\tdo norte");

//O caractere (\b) retira um caractere na string (assim como a tecla BACKSPACE)

Console.WriteLine(exemplo + " do\b norte");
Console.WriteLine("Digite uma letra");

string letra = Console.ReadLine();
string resposta = "";

// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
// {
//     resposta = ("É uma vogal");
// }
// else
// {
//     resposta = "Não é uma vogal";
// }

// Console.WriteLine(resposta);

// switch (letra)
// {
//     case "a":
//         resposta = ("É uma vogal");
//         break;
//     case "e":
//         resposta = ("É uma vogal");
//         break;
//     case "i":
//         resposta = ("É uma vogal");
//         break;
//     case "o":
//         resposta = ("É uma vogal");
//         break;
//     case "u":
//         resposta = ("É uma vogal");
//         break;
//
//     default:
//         resposta = "Não é uma vogal";
//         break;
// }

// Console.WriteLine(resposta);

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        resposta = ("É uma vogal");
        break;

    default:
        resposta = "Não é uma vogal";
        break;
}

Console.WriteLine(resposta);
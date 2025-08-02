using classe_object.Models;

//A classe object é a classe mãe de todas as classes no C#, assim elas serviços de baixo nível

Computador pc = new Computador();

//Exemplos de serviços de baixo nível herdados

// pc.Equals(pc);
// pc.GetHashCode();
// pc.GetType();
// pc.ToString();

//Sobrescrevendo serviços de baixo nível

Console.WriteLine(pc.ToString());
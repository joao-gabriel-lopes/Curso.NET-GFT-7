using interfaces.Interfaces;
using interfaces.Models;

//Uma interface é um contrato que pode ser implementado por uma classe, definindo métodos que essas classes devem possuir. Além disso, uma mesma classe pode implementar várias interfaces

//ICalculadora calc = new ICalculadora(); //Não é possível instanciar um interface

Calculadora calc = new Calculadora();
calc.Somar(2, 6);
calc.Subtrair(7, 3);
calc.Multiplicar(5, 8);
calc.Dividir(10, 5);

//Outra maneira de instanciar uma classe que implementa um interface

//ICalculadora calc = new Calculadora();


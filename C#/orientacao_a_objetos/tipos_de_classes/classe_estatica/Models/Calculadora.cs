using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classe_estatica.Models
{
    //Exemplo de classe estática
    public static class Calculadora
    {
        //Exemplo de atributo estático
        public static string? Modelo { get; set; }

        //Exemplo de atributo estático
        public static int NumeroDigitos { get; set; }

        //Exemplo de método estático
        public static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        //Exemplo de método estático
        public static int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        //Exemplo de método estático
        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        //Exemplo de método estático
        public static int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
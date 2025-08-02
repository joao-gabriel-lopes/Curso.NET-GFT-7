using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.Models
{
    public class Calculadora
    {
        public void Somar(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public void Subtrair(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        public void Multiplicar(int num1, int num2)
        {
            Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
        }

        public void Dividir(int num1, int num2)
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }

        public void Potencia(int num1, int num2)
        {
            double pot = Math.Pow(num1, num2);
            Console.WriteLine($"{num1}^{num2} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}° = {Math.Round(cosseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double num)
        {
            double raiz = Math.Sqrt(num);
            Console.WriteLine($"Raiz quadrada de {num} = {raiz}");
        }

    }
}
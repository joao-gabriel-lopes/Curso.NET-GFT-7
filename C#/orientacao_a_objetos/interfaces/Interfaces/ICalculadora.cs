using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interfaces.Interfaces
{
    //Exemplo de interface
    public interface ICalculadora
    {
        //Métodos sem conteúdo são obrigatórios de serem implementados nas classes
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);

        //Métodos com conteúdo são opcionais de serem implementados nas classes
        // int Somar(int num1, int num2)
        // {
        //     return num1 + num2;
        // }

    }
}
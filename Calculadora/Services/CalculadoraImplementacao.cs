using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Dividir(int num1, int num2)
        {
            if(num2 == 0)
            throw new DivideByZeroException("Divisão por zero não é permitida!");

            return num1/num2;
        }

        public bool ehPar(int num)
        {
            return num % 2 == 0;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1*num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1-num2;
        }
    }
}
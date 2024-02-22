using System;
using System.Runtime.CompilerServices;

namespace Biblioteca
{
    public static class Calculadora
    {
        public static double Calcular(double operando1, double operando2, string operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    if (Validar(operando2))
                    {
                    resultado = operando1 / operando2;
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(double operador2)
        {
            return operador2 != 0;
        }
    }
}

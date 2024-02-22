using Biblioteca1;
using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio I04 - La calculadora\n!");

            double operando1 = PedirDatoDouble("Ingrese primer operando:");
            string operadorAritmetico = PedirOperadorAritmetico();
            double operando2 = PedirDatoDouble("Ingrese segundo operando:");

            double resultado = CalculadoraUno.Calcular(operando1, operando2, operadorAritmetico);
            Console.WriteLine($"{operando1} {operadorAritmetico} {operando2} = {resultado}");
        }

        public static double PedirDatoDouble(string leyenda)
        {
            double retorno;
            while (true)
            {
                Console.WriteLine(leyenda);
                if (double.TryParse(Console.ReadLine(), out retorno))
                {
                    return retorno;
                }
                else
                {
                    Console.WriteLine("Valor ingresado inválálido, volver a ingresar.");
                }

            }
        }

        public static string PedirOperadorAritmetico()
        {
            string retorno = "";
            while (true)
            {
                Console.WriteLine("Ingresar operador aritmetico, porfavor:");
                retorno = Console.ReadLine();
                if (retorno == "+" || retorno == "-" || retorno == "*" || retorno == "/")
                {
                    return retorno;
                }
                else
                {
                    Console.WriteLine("operador no válido\n");
                }
            }
        }
    }
}

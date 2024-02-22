using System;

namespace Hola_Mundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 32;
            int numeroDos = 10;
            int resultado = numeroUno - numeroDos;

            

            Console.Write("{0} - {1} = {2}\n", numeroUno, numeroDos, resultado);
            Console.Write("{0,-10} {1,-10} {2,10}\n", "N° 1", "N° 2", "resultado");
            Console.Write("{0,-10:N2} {1,-10:N2} {2,10:N2}\n", numeroUno, numeroDos, resultado);

            Console.WriteLine("Ingrese su peso:");
            string pesoIngresado = Console.ReadLine();
            int peso = int.Parse(pesoIngresado) + 100;

            //Texto con color
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Su peso es de {0} kg.", peso);

            
        }
    }
}


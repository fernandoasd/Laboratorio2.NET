using Biblioteca;
using System;

namespace DeseaContinuar102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            bool respuesta = true;

            Console.WriteLine("Suma de números enteros.");
            while (respuesta)
            {
                Console.WriteLine("Por favor, ingrese un número.");
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    acumulador += numeroIngresado;
                }
                else 
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico");
                }
                Console.WriteLine("Desea continuar? s/n");
                respuesta = Validador.ValidarRespuesta(Console.ReadLine());
            }
            Console.WriteLine($"\nLa suma total es: {acumulador}");
        }
    }
}

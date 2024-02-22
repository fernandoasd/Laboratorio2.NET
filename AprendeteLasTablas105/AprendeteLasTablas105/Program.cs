using Biblioteca;
using System;

namespace AprendeteLasTablas105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio I05 - Aprendete las tablas!");
            string tabla = "";
            while (true)
            {
                Console.WriteLine("Ingrese un número para hacer la tabla:");
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    tabla = Tabla.HcaerTabla(numeroIngresado);
                    break;
                }
                
            }
            Console.WriteLine(tabla);
        }
    }
}

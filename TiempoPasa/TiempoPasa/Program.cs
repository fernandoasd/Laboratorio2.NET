using Biblioteca;
using System;

namespace TiempoPasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anio, mes, dia;
            Console.WriteLine("Ejercicio I08 - El tiempo pasa...\n");

            Console.WriteLine("Calcularemos la edad. Ingrese Año de nacimiento:");
            anio = PedirDatoEntero("Ingresar anio");
            mes = PedirDatoEntero("Ingresar mes");
            dia = PedirDatoEntero("ingresar dia");

            Console.WriteLine($"Han pasado {CalculadoraDias.CalcularDias(anio, mes, dia)} días.");
        }

        public static int PedirDatoEntero(string leyenda)
        {
            int retorno;
            while (true)
            {
                Console.WriteLine(leyenda);
                if (int.TryParse(Console.ReadLine(), out retorno))
                {
                    return retorno;
                }
                else
                {
                    Console.WriteLine("Valor ingresado inválálido, volver a ingresar.");
                }

            }
        }

    }
}

using Biblioteca;
using System;

namespace PitagorasOrgulloso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio I07 - Pitágoras estaría orgulloso!\n");

            double hipotenusa, baseTriangulo, alturaTriangulo;
            while (true)
            {
                Console.WriteLine("Ingrese la longitud de la base del triangulo:");
                if (double.TryParse(Console.ReadLine(), out baseTriangulo))
                {
                    Console.WriteLine("Ingrese la altura del triangulo:");
                    if (double.TryParse(Console.ReadLine(), out alturaTriangulo))
                    {
                        hipotenusa = Calculadora.CalcularHipotenusa(baseTriangulo, alturaTriangulo);
                        break;
                    }
                }
                else 
                {
                    Console.WriteLine("Valor incorrecto, volver a ingresar.");
                }
            }
            Console.WriteLine($"Triángulo: Base: {baseTriangulo} Altura: {alturaTriangulo} Hipotenusa: {hipotenusa}");
        }
    }
}

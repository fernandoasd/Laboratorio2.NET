using Biblioteca;
using System;

namespace Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota felix = new Mascota("Feliz", new DateTime(2020,01,01), "felino");

            Console.WriteLine($"nombre: {felix.GetNombre()} nacimiento = {felix.GetFechaNacimiento()}");

            felix.SetNombre("Horacio");

            Console.WriteLine($"{felix.GetNombre()}");
        }
    }
}

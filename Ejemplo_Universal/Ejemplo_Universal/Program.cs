using Biblioteca;
using System;

namespace Ejemplo_Universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante pepe = new Estudiante("gomez", "25651", "pepe");
            Estudiante juan = new Estudiante("gomez", "25652", "juan");
            Estudiante jack = new Estudiante("gomez", "25653", "jack");

            pepe.SetNotaPrimerParcial(7);
            pepe.SetNotaSegundoParcial(8);

            juan.SetNotaPrimerParcial(9);
            juan.SetNotaSegundoParcial(10);

            jack.SetNotaPrimerParcial(1);
            jack.SetNotaSegundoParcial(3);

            Console.WriteLine(pepe.Mostrar());
            Console.WriteLine(juan.Mostrar());
            Console.WriteLine(jack.Mostrar());

            Console.WriteLine(pepe == juan);
            Console.WriteLine(pepe != juan);

            int numero = pepe;
            Console.WriteLine(numero);

            Estudiante mauricio = (Estudiante)"Iriarte, 25665, Mauricio";
            Console.WriteLine(mauricio.ToString());

        }
    }
}

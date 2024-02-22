using Biblioteca;
using System;

namespace POO_prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta juan = new Cuenta("Juan Pablo", 10000);

            Console.WriteLine(juan.Mostrar());
            juan.Ingresar(1500);
            juan.Retirar(33);
            Console.WriteLine(juan.Mostrar());
        }
    }
}

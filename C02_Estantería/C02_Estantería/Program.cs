using Biblioteca;
using System;

namespace C02_Estantería
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto pinza = new Producto("236598", "Dogo", 3200F);
            Producto tijera = new Producto("236570", "Dogo", 3000F);
            Producto linterna = new Producto("200021", "alic", 4000F);

            //Console.WriteLine($"C-Barra {(string)pinza} marca: {pinza.GetMarca()} precio: {pinza.GetPrecio()}");
            //Console.WriteLine($"pinza == tijera: {pinza == tijera}");
            //Console.WriteLine($"linterna == tijera: {linterna == tijera}");
            //Console.WriteLine($"linterna == alic: {linterna == "alic"}");
            //Console.WriteLine($"linterna == tramontina: {linterna == "tramontina"}");

            Estante estanteUno = new Estante(3, 6);
            Console.WriteLine($"EstanteUNo != linterna: {estanteUno != linterna}");

            if (estanteUno + linterna)
            {
                Console.WriteLine("Se agregó linterna");
            }

            if (estanteUno + linterna)
            {
                Console.WriteLine($"Se agregó producto:C. Barras {(string)linterna} {linterna.GetMarca()} {linterna.GetPrecio()}");
            }
            else
            {
                Console.WriteLine($"No se agregó producto:C. Barras {(string)linterna} {linterna.GetMarca()} {linterna.GetPrecio()}");
            }

            if (estanteUno + pinza)
            {
                Console.WriteLine($"Se agregó producto:C. Barras {(string)pinza} {pinza.GetMarca()} {pinza.GetPrecio()}");
            }
            else
            {
                Console.WriteLine($"No se agregó producto:C. Barras {(string)pinza} {pinza.GetMarca()} {pinza.GetPrecio()}");
            }

            if (estanteUno + tijera)
            {
                Console.WriteLine($"Se agregó producto:C. Barras {(string)tijera} {tijera.GetMarca()} {tijera.GetPrecio()}");
            }
            else
            {    
                Console.WriteLine($"No se agregó producto:C. Barras {(string)tijera} {tijera.GetMarca()} {tijera.GetPrecio()}");
            }

            



            Console.WriteLine($"EstanteUNo == linterna: {estanteUno == linterna}");
            Console.WriteLine($"Mostrar estanteUno:\n{Estante.MostrarEstante(estanteUno)}");
            Console.WriteLine($"Eliminar tijera:\n{Estante.MostrarEstante(estanteUno - tijera)}");





        }
    }
}

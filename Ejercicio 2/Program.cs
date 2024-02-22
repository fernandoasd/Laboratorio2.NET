/*
Ejercicio 2
Consigna
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
-Utilizar el método Pow de la clase Math para calcular las potencias.
*/

using System.ComponentModel;

String respuesta = "";
bool seguir = true;
int numeroIngresado = 0;
Console.ForegroundColor = ConsoleColor.Green;

do
{
    Console.Write("Ingrese un numero >0: ");
    if (int.TryParse(Console.ReadLine(), out numeroIngresado) & numeroIngresado > 0)
    {
        Console.WriteLine($"{numeroIngresado}^2 = {(long)Math.Pow(numeroIngresado, 2)}");
        Console.WriteLine($"{numeroIngresado}^3 = {(long)Math.Pow(numeroIngresado, 3)}");
    }
        
    else 
    {
        Console.WriteLine("El valor tiene que ser > 0, ingrese nuevamente");
    }

    Console.WriteLine("Quiere ingresar otro número? y/n ");
    respuesta = Console.ReadLine();
    if (respuesta != "y")
        seguir = false;
    else
    {
        Console.Clear();
    }

}
while (seguir);


/*
 Consigna
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario,
cerrar la consola.
*/

bool seguir = true;
int numeroIngresado = 0;
double resto = 0;


do
{
    Console.Write("Ingrese un número positivo: ");
    if (int.TryParse(Console.ReadLine(), out numeroIngresado) & numeroIngresado >= 0)
    {
        for (int i = 1; i <= numeroIngresado; i++)
        {
            resto = numeroIngresado - (numeroIngresado / )
        }
    }
}
while (seguir);

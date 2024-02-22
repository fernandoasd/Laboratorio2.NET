/*Ejercicio 01 - Máximo, mínimo y promedio
Consigna
Ingresar 5 números por consola, guardándolos en una variable escalar.
Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/


int numeroUno = 0;
int numeroDos = 0;
int numeroTres = 0;
int numeroCuatro = 0;
int numeroCinco = 0;
int numeroMayor = 0;
int numeroMenor = 0;
int sumaTotal = 0;
int promedio = 0;
bool seguir = true;
string respuesta = "";

do
{
    int contadorNumeros = 1;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;

    Console.Write("Ingrese {0}° número: ", contadorNumeros);
    numeroUno = int.Parse(Console.ReadLine());
    contadorNumeros += 1;
    Console.Clear();
    Console.Write("Ingrese {0}° número: ", contadorNumeros);
    numeroDos = int.Parse(Console.ReadLine());
    contadorNumeros += 1;
    Console.Clear();
    Console.Write("Ingrese {0}° número: ", contadorNumeros);
    numeroTres = int.Parse(Console.ReadLine());
    contadorNumeros += 1;
    Console.Clear();
    Console.Write("Ingrese {0}° número: ", contadorNumeros);
    numeroCuatro = int.Parse(Console.ReadLine());
    contadorNumeros += 1;
    Console.Clear();
    Console.Write("Ingrese {0}° número: ", contadorNumeros);
    numeroCinco = int.Parse(Console.ReadLine());
    contadorNumeros += 1;
    Console.Clear();

    if (numeroUno > numeroDos)
    {
        numeroMayor = numeroUno;
        numeroMenor = numeroDos;
    }
    else
    {
        numeroMayor = numeroDos;
        numeroMenor = numeroUno;
    }

    if (numeroTres > numeroMayor)
    {
        numeroMayor = numeroTres;
    }
    else if (numeroTres < numeroMenor)
    {
        numeroMenor = numeroTres;
    }

    if (numeroCuatro > numeroMayor)
    {
        numeroMayor = numeroCuatro;
    }
    else if (numeroCuatro < numeroMenor)
    {
        numeroMenor = numeroCuatro;
    }

    if (numeroCinco > numeroMayor)
    {
        numeroMayor = numeroCinco;
    }
    else if (numeroCinco < numeroMenor)
    {
        numeroMenor = numeroCinco;
    }

    sumaTotal = numeroUno + numeroDos + numeroTres + numeroCuatro + numeroCinco;
    promedio = sumaTotal / 5;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("El numero mayor es {0}.\nEl numero menor es {1}.\nElpromedio es {2}\n", numeroMayor, numeroMenor, promedio);

    Console.WriteLine("Desea volver a comenzar? y/n");
    respuesta = Console.ReadLine();

    if (respuesta != "y")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("EXIT");
        seguir = false;
    }
}
while (seguir);
















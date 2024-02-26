using Billetes;
using System;

namespace ejercicioCotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolaresAhorrados = new Dolar(100);
            Euro equivalenteAEuros = (Euro)dolaresAhorrados;
            Peso equivalenteAPesos = (Peso)dolaresAhorrados;

            Dolar dolaresGastados = new Dolar(90);

            Console.WriteLine($"Conv Explícita: 100 usd equivalen a {equivalenteAEuros.GetCantidad()} Euros");
            Console.WriteLine($" Son iguales?: {dolaresAhorrados == equivalenteAEuros}");
            Console.WriteLine($" Son distintos?: {dolaresAhorrados != equivalenteAEuros}\n");

            Console.WriteLine($"Conv Explícita: 100 usd equivalen a {equivalenteAPesos.GetCantidad()} Pesos");
            Console.WriteLine($" Son iguales?: {dolaresAhorrados == equivalenteAPesos}");
            Console.WriteLine($" Son distintos?: {dolaresAhorrados != equivalenteAPesos}\n");

            Console.WriteLine($"Dolares ahorrados == gastados: {dolaresAhorrados == dolaresGastados}");
            Console.WriteLine($"Dolares ahorrados != gastados: {dolaresAhorrados != dolaresGastados}");

            Console.WriteLine($"Dolares implicitos == ahorrados: {((Dolar)100.0) == dolaresAhorrados}");




        }
    }
}

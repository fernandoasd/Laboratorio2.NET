using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sum = new Sumador(3);
            Sumador sum2 = new Sumador(5);

            Console.WriteLine(sum.Sumar(2,3));
            Console.WriteLine(sum.Sumar("A", "SD"));

            int intSum = (int)sum;
            int intSum2 = (int)sum2;

            Console.WriteLine($"Conversion explicitita sum {intSum}");
            Console.WriteLine($"Conversion explicitita sum2 {intSum2}");

            Console.WriteLine($"Sobrecarga operador + {sum + sum2}");

            Console.WriteLine($"Sobrecarga | { sum | sum2}");




        }
    }
}

using Biblioteca;
using System;

namespace ConversorBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.ConvertirDecimalABinario(34));
            Console.WriteLine(Conversor.ConvertirBinarioADecimal(100010)); ;
        }
    }
}

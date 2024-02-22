using System;
using System.Text;
using Biblioteca;

namespace ValidarRangosConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int rangoMin = -100;
            int rangoMax = 100;
            int valorMin = rangoMax;
            int valorMax = rangoMin;
            int contador = 0;
            int acumulador = 0;
            int promedio;
            bool esNumero;
            while (contador < 3)
            {
                Console.WriteLine("Ingrese un número");
                esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (esNumero && Validador.Validar(numeroIngresado, rangoMin, rangoMax))
                {
                    if (numeroIngresado > valorMax)
                    {
                        valorMax = numeroIngresado;
                    }
                    else if (numeroIngresado < valorMin)
                    {
                        valorMin = numeroIngresado;
                    }

                    acumulador += numeroIngresado;
                    contador += 1;
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un numero valido.");
                }
            }

            promedio = acumulador / contador;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Valor min: {valorMin}"); //con salto de linea
            stringBuilder.AppendFormat($"Valor max: {0}\n", valorMax); //formato compuesto
            stringBuilder.Append($"Promedio: {promedio}"); //sin salto de linea

            Console.WriteLine(stringBuilder.ToString());

            
            //Console.WriteLine("Valor min: {0} \nValor max: {1}\nPromedio {2}", valormin, valorMax, promedio);


        }
    }
}

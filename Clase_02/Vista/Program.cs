using System;
using Biblioteca;


namespace Vista
{
    internal class Program
    {
        private static float temperaturaCelsius;
        private static float temperaturaKelvin;

        static void Main(string[] args)
        {
             temperaturaCelsius = 140F;
            temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);

            temperaturaCelsius = ConversorDeTemperatura.ConvertirKelvinACelsius(temperaturaKelvin);

            MostrarTemperaturas();
        }

        static void MostrarTemperaturas()
        {
            Console.WriteLine("Temperatura Celsius: {0}", temperaturaCelsius);
            Console.WriteLine("Temperatura Kelvin: {0}", temperaturaKelvin);
        }
    }
}

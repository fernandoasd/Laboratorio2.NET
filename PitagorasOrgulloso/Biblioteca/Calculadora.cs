using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static double CalcularHipotenusa(double longitudBase, double altura)
        {
            return Math.Sqrt(Math.Pow(longitudBase, 2) + Math.Pow(altura, 2));
        }
    }
}

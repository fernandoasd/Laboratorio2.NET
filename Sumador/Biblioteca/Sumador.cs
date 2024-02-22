using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        public long Sumar(long n1, long n2)
        {
            this.cantidadSumas += 1;
            return n1 + n2;
        }

        public string Sumar(string n1, string n2)
        {
            this.cantidadSumas += 1;
            return string.Format($"{n1}{n2}");
        }

        public static explicit operator int(Sumador sum)
        {
            return sum.cantidadSumas;
        }

        public static long operator + (Sumador sum1, Sumador sum2)
        {
            return sum1.cantidadSumas + sum2.cantidadSumas;
        }

        public static bool operator |(Sumador sum1, Sumador sum2)
        {
            return sum1.cantidadSumas == sum2.cantidadSumas;
        }

    }
}

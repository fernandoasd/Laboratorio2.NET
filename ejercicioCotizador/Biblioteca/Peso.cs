using System;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Peso()
        {
            cotizRespectoDolar = 0.000921659;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static void SetCotizacion(double d)
        {
            cotizRespectoDolar = d;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static explicit operator Dolar(Peso p)
        {
            return (Dolar)(p.GetCantidad() * Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return p.cantidad != d.GetCantidad();
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return !(p != d);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return p.cantidad != e.GetCantidad();
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return !(p != e);
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return p1.cantidad != p2.cantidad;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return !(p1 != p2);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return (Peso)(p.cantidad - d.GetCantidad());
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return (Peso)(p.cantidad - e.GetCantidad());
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return (Peso)(p.cantidad + d.GetCantidad());
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return (Peso)(p.cantidad + e.GetCantidad());
        }

        public override string ToString()
        {
            string dinero = $"{this.cantidad}";
            return dinero;
        }
    }
}

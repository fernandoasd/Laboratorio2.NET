using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1.0;
        }

        public Dolar(double cantidad)
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

        public static explicit operator Euro(Dolar d)
        {
            return (Euro)(d.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return (Peso)(d.cantidad / Peso.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return ((Dolar)e).GetCantidad() != d.cantidad;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return !(d != e);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return ((Dolar)p).GetCantidad() != d.cantidad;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return !(d != p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return (d1.cantidad != d2.cantidad);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return !(d1 != d2);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return (Dolar)(d.cantidad - ((Dolar)e).cantidad);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return (Dolar)(d.cantidad - ((Dolar)p).cantidad);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return (Dolar)(d.cantidad + ((Dolar)e).cantidad);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return (Dolar)(d.cantidad + ((Dolar)p).cantidad);
        }

        public override string ToString()
        {
            string dinero = $"{this.cantidad}";
            return dinero;
        }



    }
}

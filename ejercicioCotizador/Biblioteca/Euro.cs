using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad)
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

        public static explicit operator Dolar(Euro e)
        {
            return (Dolar)(e.GetCantidad() * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return e.cantidad != d.GetCantidad();
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return !(e != d);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return e.cantidad != p.GetCantidad();
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return !(e != p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return e1.cantidad != e2.cantidad;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return !(e1 != e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return (Euro)(e.cantidad - d.GetCantidad());
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return (Euro)(e.cantidad - p.GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return (Euro)(e.cantidad + d.GetCantidad());
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return (Euro)(e.cantidad + p.GetCantidad());
        }

        public override string ToString()
        {
            string dinero = $"{this.cantidad}";
            return dinero;
        }




    }
}

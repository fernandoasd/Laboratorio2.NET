using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private int cantidad;

        public Cuenta()
        {
        }

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public bool SetTitular(string titular)
        {
            if (titular != null && titular != "")
            {
                this.titular = titular;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool SetCantidad(int cantidad)
        {
            if (cantidad >= 0)
            {
                this.cantidad = cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetTitular()
        {
            return titular;
        }

        public int GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder informacionCuenta = new StringBuilder();
            informacionCuenta.AppendLine($"Titular de la cuent: {GetTitular()} \n Saldo $ {GetCantidad()}");

            return informacionCuenta.ToString();
        }

        public void Ingresar( int ingresarCantidad)
        {
            SetCantidad(ingresarCantidad);
        }

        public void Retirar(int retirarCantidad)
        {
            if (retirarCantidad >= 0)
            {
                this.cantidad -= retirarCantidad;
            }
        }


    }
}

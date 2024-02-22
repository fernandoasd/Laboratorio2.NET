using System;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder detalleProducto = new StringBuilder();

            detalleProducto.AppendLine($"Codigo de Barras {(string)p}");
            detalleProducto.AppendLine($"Marca: {p.GetMarca()}");
            detalleProducto.AppendLine($"Precio: ${p.GetPrecio()}");
            detalleProducto.AppendLine($"---------------------------");


            return detalleProducto.ToString();
        }

        public static explicit operator string(Producto producto)
        {
            string respuesta = "";
            if (producto is not null)
            {
                respuesta = producto.codigoDeBarra;
            }

            return respuesta;
        }

        public static bool operator == (Producto p1, Producto p2)
        {
            bool respuesta = false;
            if ((string)p1 == (string)p2 && p1.GetMarca() == p2.GetMarca())
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator != (Producto p1, Producto p2)
        {
            bool respuesta = true;
            if ((string)p1 == (string)p2 && p1.GetMarca() == p2.GetMarca())
            {
                respuesta = false;
            }
            return respuesta;
        }

        public static bool operator == (Producto p1, string marca)
        {
            bool respuesta = false;
            if (p1.GetMarca() == marca)
            {
                respuesta = true;
            }
            return respuesta;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            bool respuesta = true;
            if (p1.GetMarca() == marca)
            {
                respuesta = false;
            }
            return respuesta;
        }
    }

    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante est)
        {
            StringBuilder datosEstante = new StringBuilder($"Ubicación del estante: {est.ubicacionEstante}\n");
            foreach (Producto producto in est.productos)
            {
                if (producto is not null)
                {
                    datosEstante.AppendLine(Producto.MostrarProducto(producto));
                }
            }
            return datosEstante.ToString();
        }

        /// <summary>
        ///  Retornará true si es que el producto ya se encuentra en el estante, false caso contrario
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Estante e, Producto p)
        {
            bool respuesta = false;
            foreach (Producto productoArray in e.productos)
            {
                if (productoArray == p)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }

        /// <summary>
        ///  Retornará false si es que el producto ya se encuentra en el estante, true caso contrario
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        /// <summary>
        ///  Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y 
        ///  dicho producto no se encuentra en el estante, false caso contrario
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto p)
        {
            bool respuesta = false;
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        respuesta = true;
                        break;
                    }
                }
            }
            return respuesta;
        }

        /// <summary>
        /// Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        return e;
                    } 
                }
            }
            return e;
        }


    }
}

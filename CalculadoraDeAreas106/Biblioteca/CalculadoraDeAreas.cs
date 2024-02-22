using System;

namespace Biblioteca
{
    public class CalculadoraDeAreas
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo(double longitudBase, double altura)
        {
            return longitudBase * altura / 2;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }
    }

    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            return respuesta == "1" || respuesta == "2" || respuesta == "3";
        }

        public static bool ValidarLongitud(string longitud)
        {
            return double.TryParse(longitud, out double longitudValida);
        }
    }
}

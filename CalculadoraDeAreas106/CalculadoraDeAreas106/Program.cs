using Biblioteca;
using System;
using System.Text;

namespace CalculadoraDeAreas106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            string figuraGeometrica = "";
            double area = 0.0;
            bool seguir = true;
            Console.WriteLine("Ejercicio I06 - Calculadora de áreas!\n");

            while (seguir)
            {
                Console.WriteLine("Que área desea calcular?\n1- Un cuadrado \n2-Un triángulo \n3-Un círculo");
                respuesta = Console.ReadLine();
                if (Validador.ValidarRespuesta(respuesta))
                {
                    switch (respuesta)
                    {
                        case "1":
                            Console.WriteLine("Ingrece la longitud del lado del cuadrado:");
                            if (double.TryParse(Console.ReadLine(), out double longitudValida))
                            {
                                area = CalculadoraDeAreas.CalcularAreaCuadrado(longitudValida);
                                figuraGeometrica = "rectangulo";
                                seguir = false;
                            }
                            else
                            {
                                Console.WriteLine("Por favor ingrese un valor numérico.");
                            }
                            break;

                        case "2":
                            Console.WriteLine("Ingrece la longitud de la base del triangulo:");
                            if (double.TryParse(Console.ReadLine(), out double baseTriangulo))
                            {
                                Console.WriteLine("Ingrece la altura del triangulo:");
                                if (double.TryParse(Console.ReadLine(), out double alturaTriangulo))
                                {
                                    area = CalculadoraDeAreas.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                                    figuraGeometrica = "triangulo";
                                    seguir = false;
                                }
                                else
                                {
                                    Console.WriteLine("Por favor ingrese un valor numérico.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Por favor ingrese un valor numérico.");
                            }
                            
                            break;

                        case "3":
                            Console.WriteLine("Ingrece el radio del circulo:");
                            if (double.TryParse(Console.ReadLine(), out double radio))
                            {
                                area = CalculadoraDeAreas.CalcularAreaCirculo(radio);
                                figuraGeometrica = "circulo";
                                seguir = false;
                            }
                            else
                            {
                                Console.WriteLine("Por favor ingrese un valor numérico.");
                            }
                            break;
                    } // end switch
                } //end if
                else 
                {
                    Console.WriteLine("Valor invalido. Volver a ingresar.");
                }
            } //end while
            Console.WriteLine($"El área del {figuraGeometrica} es {area}.");
        }
    }
}

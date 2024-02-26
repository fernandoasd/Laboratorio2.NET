using System;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] arrayCursos = new string[0];
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.arrayCursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder datosIngresante = new StringBuilder();
            string cursos = "";
            datosIngresante.AppendLine($"Nombre: {this.nombre}");
            datosIngresante.AppendLine($"Dirección: {this.direccion}");
            datosIngresante.AppendLine($"Edad {this.edad}");
            datosIngresante.AppendLine($"Género {this.genero}");
            datosIngresante.AppendLine($"Pais {this.pais}");

            foreach (String curso in arrayCursos)
            {
                cursos += $"  {curso}\n";
            }

            datosIngresante.Append($"Curso/s: \n{cursos}");

            return datosIngresante.ToString();
        }


    }
}

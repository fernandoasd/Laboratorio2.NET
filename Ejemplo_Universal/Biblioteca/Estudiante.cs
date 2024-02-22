using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        private int edad;


        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + (float) this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial > 3 && this.notaSegundoParcial > 3)
            {
                return random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder datosAlumnos = new StringBuilder();
            double notaFinal = this.CalcularNotaFinal();

            datosAlumnos.AppendLine($"Alumno {this.nombre} {this.apellido} n° legajo {this.legajo}");
            datosAlumnos.AppendLine($"Notas 1°P ({this.notaPrimerParcial}) | 2°P ({this.notaSegundoParcial})");
            datosAlumnos.AppendLine($"Promedio: {this.CalcularPromedio()}");
            datosAlumnos.Append("Nota final: ");
            datosAlumnos.AppendLine(notaFinal == -1 ? "Alumno Desaprobado" : notaFinal.ToString());

            return datosAlumnos.ToString();
        }

        //Sobrecarga de operador ==
        public static bool operator == (Estudiante t1, Estudiante t2)
        {
            return t1.legajo == t2.legajo;
        }

        public static bool operator != (Estudiante t1, Estudiante t2)
        {
            return t1.legajo != t2.legajo;
        }

        public static implicit operator int (Estudiante t1)
        {
            return int.Parse(t1.legajo);
        }

        /// Estudiante t = (Estudiante)"Apellido, legajo, nombre"
        public static explicit operator Estudiante(string t)
        {
            string[] estudianteStr = t.Split(",");
            Estudiante nuevoEstudiante = new Estudiante(estudianteStr[0], estudianteStr[1], estudianteStr[2]);
            return nuevoEstudiante;
        }

        public override string ToString()
        {
            string strEstudiante = $"Apellido: {this.apellido} | Legajo: {this.legajo} | Nombre: {this.nombre}";
            return strEstudiante;
        }

    }

}

using System;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Mostrar()
        {
            return $"Nombre {this.nombre} -- Edad {this.edad}";
        }

        string[] nombresPersonas = new string[0];

    }
}

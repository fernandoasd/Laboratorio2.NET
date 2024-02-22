using System;

namespace Biblioteca
{
    public class Mascota
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string especie;

        public Mascota()
        {
            nombre = "";
            fechaNacimiento = new DateTime(2001,01,01);
            especie = "";
        }

        public Mascota(string nombre, DateTime fechaNacimiento, string especie)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.especie = especie;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetFechaNacimiento()
        {
            return fechaNacimiento.ToShortDateString();
        }

        public string GetEspecie()
        {
            return especie;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetEspecie(string especie)
        {
            this.especie = especie;
        }



    }
}

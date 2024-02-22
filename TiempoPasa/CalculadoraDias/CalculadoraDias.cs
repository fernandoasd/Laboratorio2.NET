using System;

namespace Biblioteca
{
    public class CalculadoraDias
    {
        public static int CalcularDias(int anio, int mes, int dia)
        {
            DateTime fechaLocal = DateTime.Now;
            DateTime fechaNacimiento = new DateTime(anio, mes, dia);

            TimeSpan diferencia = fechaLocal - fechaNacimiento;
            return diferencia.Days;
        }
    }
}

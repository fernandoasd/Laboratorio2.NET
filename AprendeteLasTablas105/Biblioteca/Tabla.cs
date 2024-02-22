using System;
using System.Text;

namespace Biblioteca
{
    public static class Tabla
    {
        public static string HcaerTabla (int numero)
        {
            int resultado;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Tabla de multiplica del {numero}:\n");

            for (int i = 1; i < 10; i++)
            {
                resultado = numero * i;
                stringBuilder.AppendLine($"{numero} * {i} = {resultado}");
            }
            
            return stringBuilder.ToString();
        }
    }
}

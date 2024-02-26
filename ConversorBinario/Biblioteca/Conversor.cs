using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            int dividendo = numeroEntero;
            double divisor = 2;
            double cociente = divisor + 1;
            int indice = 0;
            string[] restos = new string[indice];
            string[] cocienteSplit = new string[0];
            StringBuilder strBinario = new StringBuilder();


            while (dividendo != 0)
            {
                cociente = dividendo / divisor;
                string cocienteATexto = cociente.ToString();
                cocienteSplit = cocienteATexto.Split(",");
                dividendo = int.Parse(cocienteSplit[0]);

                Array.Resize<string>(ref restos, indice + 1);

                if (cocienteSplit.Length > 1)
                {
                    restos[indice] = "1";
                }
                else
                {
                    restos[indice] = "0";
                }

                indice++;
            }

            for (int i = restos.Length - 1; i >= 0; i--)
            {
                strBinario.Append(restos[i]);
            }

            return strBinario.ToString();
        }

        public static string ConvertirBinarioADecimal(int numeroBinario)
        {
            string binarioAString = numeroBinario.ToString();
            char[] arrayBinario = binarioAString.ToCharArray();
            double numeroDecimal = 0;
            int exponente = 0;
            string charString;
            string[] charSplit = new string[0];
            int parteEntera;


            for (int i = arrayBinario.Length - 1; i >= 0; i--)
            {
                charString = Char.GetNumericValue(arrayBinario[i]).ToString();
                charSplit = charString.Split(",");
                parteEntera = int.Parse(charSplit[0]);
                if (parteEntera == 0 || parteEntera == 1)
                {
                    numeroDecimal += parteEntera * Math.Pow(2, exponente);
                    exponente++;
                }
                else 
                {
                    numeroDecimal = -1;
                    break;
                }
                
            }

            return numeroDecimal.ToString();
        }

    }
}

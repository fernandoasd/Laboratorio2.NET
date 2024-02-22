namespace Biblioteca
{
    public class ConversorDeTemperatura
    {
        private const float ceroAbsoluto = 273.15F;
        /// <summary>
        /// Convierte grados celsius a kelvin
        /// </summary>
        /// <param name="temperaturaCelsius">Temperatura en grados celsius</param>
        /// <returns>Temperatura equivalente a grados kelvinS</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            float temperaturaKelvin = temperaturaCelsius + ceroAbsoluto;
            return temperaturaKelvin;
        }

        /// <summary>
        /// Convierte temperatura en grados kelvin a centígrados
        /// </summary>
        /// <param name="temperaturaKelvin">temperatura en grados kelvin</param>
        /// <returns>Grados centígrados equivalentes</returns>
        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            float TemperaturaCelsius = temperaturaKelvin - ceroAbsoluto;
            return TemperaturaCelsius;
        }

    }
}

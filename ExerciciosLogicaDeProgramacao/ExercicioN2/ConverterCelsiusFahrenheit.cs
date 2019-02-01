using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN2
{
    public class ConverterCelsiusFahrenheit
    {
        public double CelsiusParaFahrenheit(double temperaturaEmCelsius)
        {
            var temperaturaEmFahrenheit = ((temperaturaEmCelsius / 5) * 9) + 32;
            return temperaturaEmFahrenheit;
        }

        public double FahrenheitParaCelsius (double temperaturaEmFahrenheit)
        {
            var temperaturaEmCelsius = ((temperaturaEmFahrenheit - 32) / 9) * 5;
            return temperaturaEmCelsius;

        }
    }
}

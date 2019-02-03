using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ExerciciosLogicaDeProgramacao.ExercicioN2;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class ConverterCelsiusFahrenheitTest
    {
        private ConverterCelsiusFahrenheit converterCelsiusFahrenheit;
        public ConverterCelsiusFahrenheitTest()
        {
            converterCelsiusFahrenheit = new ConverterCelsiusFahrenheit();
        }

        [Fact]
        public void ConverteATemperaturaDeCelsiusParaFahrenheit()
        {
            var temperaturaEmCelsius = 10;
            var temperaturaEmFahrenheit =
                converterCelsiusFahrenheit.CelsiusParaFahrenheit(temperaturaEmCelsius);

            Assert.Equal(50, temperaturaEmFahrenheit);
        }

        [Fact]
        public void ConverteATemperaturaDeFahrenheitParaCelsius()
        {
            var temperaturaEmFahrenheit = 500;
            var temperaturaEmCelsius =
                converterCelsiusFahrenheit.FahrenheitParaCelsius(temperaturaEmFahrenheit);

            Assert.Equal(260, temperaturaEmCelsius);
        }
    }
}
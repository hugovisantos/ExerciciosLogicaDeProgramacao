using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ExerciciosLogicaDeProgramacao.ExercicioN3;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class SomarDigitosTest
    {
        [Fact]
        public void DeveSomaOsDigitosDeUmNumero()
        {
            var somarDigitos = new SomarDigitos();

            var numero = 990;
            var resultado = somarDigitos.SomaOsDigitosDeUmNumero(numero);

            Assert.Equal(18, resultado);
        }
    }
}

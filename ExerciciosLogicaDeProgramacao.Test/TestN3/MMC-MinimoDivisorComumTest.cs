using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosLogicaDeProgramacao.ExercicioN3;
using Xunit;


namespace ExerciciosLogicaDeProgramacao.Test
{
    public class MMC_MinimoDivisorComumTest
    {
        [Fact]
        public void DeveRealizarOMMCDe2Valores() {

            var mmc_MinimoDivisorComum = new MMC_MinimoDivisorComum();

            var numero1 = 12;
            var numero2 = 20;
            var resultado = mmc_MinimoDivisorComum.CalcularOMMC(numero1, numero2);

            Assert.Equal(60, resultado);
        
        }


    }
}

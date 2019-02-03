using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosLogicaDeProgramacao.ExercicioN3;
using Xunit;


namespace ExerciciosLogicaDeProgramacao.Test
{
    public class MDC_MaximoDivisorComumTest
    {
        [Fact]
        public void DeveRealizarOMDCDe2Valores()
        {
            var mdc_MaximoDivisorComum = new MDC_MaximoDivisorComum();

            var numero1 = 100;
            var numero2 = 50;
            var resultado = mdc_MaximoDivisorComum.CalcularOMDC(numero1, numero2);

            Assert.Equal(50, resultado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosLogicaDeProgramacao.ExercicioN3;
using Xunit;


namespace ExerciciosLogicaDeProgramacao.Test
{
    public class NumeroPrimoTest
    {
        [Fact]
        public void DeveTestarSeOValorEPrimo()
        {
            var numeroPrimo = new NumeroPrimo();


            var numero = 23;            
            var verificaSeEPrimo = numeroPrimo.CalcularSeONumeroEPrimo(numero);

            Assert.True(verificaSeEPrimo);
        }
    }
}

using ExerciciosLogicaDeProgramacao.ExercicioN2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class ValorParOuImparTest
    {
        [Fact]
        public void DeveCalcularSeEPar()
        {
            var valorParOuImpar = new ValorParOuImpar();
            var valor = 2;
            var valorEsperado = true;
            var verificaSeEPar = valorParOuImpar.OValorEPar(valor);
            
            Assert.True(valorEsperado == verificaSeEPar);
        }
        [Fact]
        public void DeveCalcularSeEImpar()
        {
            var valorParOuImpar = new ValorParOuImpar();
            var valor = 3;
            var valorEsperado = true;
            var verificaSeEImpar = valorParOuImpar.OValorEImpar(valor);

            Assert.True(valorEsperado == verificaSeEImpar);
        }
    }
}

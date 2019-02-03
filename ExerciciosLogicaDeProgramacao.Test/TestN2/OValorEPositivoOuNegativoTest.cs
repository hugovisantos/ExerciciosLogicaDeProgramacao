using ExerciciosLogicaDeProgramacao.ExercicioN2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class OValorEPositivoOuNegativoTest
    {
        private OValorEPositivoOuNegativo oValorEPositivoOuNegativo;
        public OValorEPositivoOuNegativoTest()
        {
            oValorEPositivoOuNegativo = new OValorEPositivoOuNegativo();
        }

        [Fact]
        public void VerificaSeOValorEPositivo()
        {
            var valor = 3;
            var valorEsperado = true;
            var validaSeEPositivo = oValorEPositivoOuNegativo.OValorEPositivo(valor);

            Assert.True(valorEsperado == validaSeEPositivo);
        }

        [Fact]
        public void VerificaSeOValorENegativo()
        {
            var valor = -3;
            var valorEsperado = true;
            var validaSeENegativo = oValorEPositivoOuNegativo.OValorENegativo(valor);

            Assert.True(valorEsperado == validaSeENegativo);
        }

        [Fact]
        public void VerificaSeOValorEZero()
        {
            var valor = 0;
            var valorEsperado = true;
            var validaSeEZero = oValorEPositivoOuNegativo.OValorEZero(valor);

            Assert.True(valorEsperado == validaSeEZero);
        }
    }
}

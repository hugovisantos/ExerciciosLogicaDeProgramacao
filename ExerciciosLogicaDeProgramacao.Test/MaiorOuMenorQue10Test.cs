using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ExerciciosLogicaDeProgramacao.ExercicioN2;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class MaiorOuMenorQue10Test
    {
        private MaiorOuMenorQue10 maiorOuMenorQue10;

        public MaiorOuMenorQue10Test()
        {
            maiorOuMenorQue10 = new MaiorOuMenorQue10();
        }

        [Fact]
        public void VerificaSeOValorEMaiorQue10()
        {
            var valor = 11;
            var valorEsperado = true;
            var verificaSeEMaiorQue10 = maiorOuMenorQue10.MaiorQue10(valor);

            Assert.True(valorEsperado == verificaSeEMaiorQue10);            
        }

        [Fact]
        public void VerificaSeOValorEMenorQue10()
        {
            var valor = 9;
            var valorEsperado = true;
            var verificaSeEMenorQue10 = maiorOuMenorQue10.MenorQue10(valor);

            Assert.True(valorEsperado == verificaSeEMenorQue10);
        }

        [Fact]
        public void VerificaSeOValorEIgualA10()
        {
            var valor = 10;
            var valorEsperado = true;
            var verificaSeEIgualA10 = maiorOuMenorQue10.IgualA10(valor);

            Assert.True(valorEsperado == verificaSeEIgualA10);
        }

    }
}

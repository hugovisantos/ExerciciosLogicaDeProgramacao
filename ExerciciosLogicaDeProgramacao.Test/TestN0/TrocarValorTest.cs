using ExerciciosLogicaDeProgramacao.ExercicioN0;
using System;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class TrocarValorTest
    {
        [Fact]
        public void Test1()
        {
            var trocarValor = new TrocarValor();

            trocarValor.A = 999;
            trocarValor.B = 555;

            trocarValor.Alterar();

            Assert.Equal(999, trocarValor.B);
            Assert.Equal(555, trocarValor.A);


        }
    }
}

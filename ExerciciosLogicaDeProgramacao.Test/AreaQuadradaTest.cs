using ExerciciosLogicaDeProgramacao.ExercicioN0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class AreaQuadradaTest
    {
        [Fact]
        public void Test1()
        {
            var areaQuadrada = new AreaQuadrada();
            var altura = 5;
            var largura = 2;
            var area = areaQuadrada.CalcularArea(altura, largura);

            Assert.Equal(10, area);

        }
    }
}

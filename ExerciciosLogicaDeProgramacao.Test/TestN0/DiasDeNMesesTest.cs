using ExerciciosLogicaDeProgramacao.ExercicioN0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class DiasDeNMesesTest
    {
        [Fact]
        public void Test1()
        {
            var diasDeNMeses = new DiasDeNMeses();
            var n = 3;
            var qtdDiasEmNMeses = diasDeNMeses.CalcularDiasDeNMeses(n);

            Assert.Equal(90, qtdDiasEmNMeses);
        }
        

    }
}

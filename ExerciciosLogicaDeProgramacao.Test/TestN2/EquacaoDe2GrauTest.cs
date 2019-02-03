using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosLogicaDeProgramacao.ExercicioN2;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class EquacaoDe2GrauTest
    {
        [Fact]
        public void CalculaUmaEquacaoDeGrau2()
        {
            var equacaoDe2Grau = new EquacaoDe2Grau();

            var a = 2;
            var b = -5;
            var c = 3;

            var (x1, x2) = equacaoDe2Grau.FormulaDeBhaskara(a, b, c);

            Assert.Equal(1.5, x1);
            Assert.Equal(1, x2);

        }
    }
}

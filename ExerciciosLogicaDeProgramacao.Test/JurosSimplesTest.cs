using ExerciciosLogicaDeProgramacao.ExercicioN1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class JurosSimplesTest
    {
        [Fact]
         public void DeveCalcularJurosSimples()
        {
            var jurosSimples = new JurosSimples();
            var capital = 10000;
            var taxaDeEmprestimo = 0.4;
            var periodos = 10;

            var juros = jurosSimples.CalcularJurosSimples(capital, taxaDeEmprestimo, periodos);

            Assert.Equal(40000, juros);
        }
    }
}

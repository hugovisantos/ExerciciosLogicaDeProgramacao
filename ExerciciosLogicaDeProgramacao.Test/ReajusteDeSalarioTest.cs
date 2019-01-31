using ExerciciosLogicaDeProgramacao.ExercicioN1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class ReajusteDeSalarioTest
    {
        [Fact]
        public void DeveRealizarOReajusteDoSalario()
        {
            var reajusteDeSalario = new ReajusteDeSalario();

            var salario = 1000;
            var reajuste = 0.15;

            var novoSalario = reajusteDeSalario.CalcularReajusteDeSalario(salario, reajuste);
            Assert.Equal(1150, novoSalario);
        }

    }
}

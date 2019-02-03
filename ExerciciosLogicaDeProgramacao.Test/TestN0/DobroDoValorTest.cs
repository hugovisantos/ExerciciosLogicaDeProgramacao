using ExerciciosLogicaDeProgramacao.ExercicioN0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class DobroDoValorTest
    {
        [Fact]
        public void Test1()
        {
            var dobroDoValor = new DobroDoValor();
            var valor = 2;
            var result = dobroDoValor.Dobrar(valor);

            Assert.Equal(4, result);

        }
    }
}

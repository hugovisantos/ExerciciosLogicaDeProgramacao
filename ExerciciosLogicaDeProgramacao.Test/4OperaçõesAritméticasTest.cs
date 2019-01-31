using ExerciciosLogicaDeProgramacao.ExercicioN1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class _4OperacoesAritmeticasTest
    {
        private _4OperacoesAritmeticas operacoesAritmeticas;

        public _4OperacoesAritmeticasTest()
        {
            operacoesAritmeticas = new _4OperacoesAritmeticas();
        }

        [Fact]
        public void DeveSomarOsValoresNumero1eNumero2()
        {            
            var numero1 = 3;
            var numero2 = 7;
            var resultado = operacoesAritmeticas.Adicao(numero1, numero2);
                       
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Test2Subtracao()
        {            
            var numero1 = 3;
            var numero2 = 1;
            var resultado = operacoesAritmeticas.Subtracao(numero1, numero2);

            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Test3Multiplicacao()
        {            
            var numero1 = 2;
            var numero2 = 3;
            var resultado = operacoesAritmeticas.Multiplicacao(numero1, numero2);

            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Test4Divisao()
        {
            var numero1 = 4;
            var numero2 = 2;
            var resultado = operacoesAritmeticas.Divisao(numero1, numero2);

            Assert.Equal(2, resultado);
        }

    }
}

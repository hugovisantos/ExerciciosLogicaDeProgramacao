using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ExerciciosLogicaDeProgramacao.ExercicioN4;

namespace ExerciciosLogicaDeProgramacao.Test.TestN4
{
    public class AlgoritmoParaSomarVetorTest
    {
        [Fact]
        public void DeveSomarOsValoresDeUmVetor()
        {
            var algoritmoParaSomarVetor = new AlgoritmoParaSomarVetor();
            
            int[] vetor = {1,2,3};

            int resultadoSoma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                resultadoSoma += vetor[i];
            }

            Assert.Equal(6, resultadoSoma);


        }
    }
}

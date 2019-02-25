using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosLogicaDeProgramacao.ExercicioN4;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test.TestN4
{
    public class AlgoritimoParaCarregarUmVetorTest
    {
        [Fact]
        public void DeveCarregarUmVetorComNumerosDe1a5()
        {
            var algoritimoParaCarregarUmVetor = new AlgoritimoParaCarregarUmVetor();

            int[] vetor = new int[5];
            var valorEsperado = 0;


            int[] test = algoritimoParaCarregarUmVetor.CarregarUmVetor(vetor);

            foreach(var valor in vetor)
            {
                Assert.Equal(valorEsperado, valor);
                valorEsperado++; 
            }

        }
    }
}

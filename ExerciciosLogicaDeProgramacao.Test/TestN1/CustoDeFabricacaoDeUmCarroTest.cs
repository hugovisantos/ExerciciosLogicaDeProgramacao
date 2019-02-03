using ExerciciosLogicaDeProgramacao.ExercicioN1;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class CustoDeFabricacaoDeUmCarroTest
    {
        [Fact]
        public void DeveCalcularOCustoDeFabricacaoDeUmCarro()
        {
            var custoDeFabricacaoDeUmCarro = new CustoDeFabricacaoDeUmCarro();

            var percentualDoDistribuidor = 0.28;
            var percentualDeImpostos = 0.45;
            var custoDeFabrica = 10000;

            var custoDeFabricacao = custoDeFabricacaoDeUmCarro.CalculaCustoDeFabricacaoDeUmCarro
                (percentualDoDistribuidor, percentualDeImpostos, custoDeFabrica);

            Assert.Equal(17300, custoDeFabricacao);
        }

    }
}

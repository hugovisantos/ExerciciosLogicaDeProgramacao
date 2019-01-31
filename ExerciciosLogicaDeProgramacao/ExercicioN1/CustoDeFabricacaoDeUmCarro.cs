using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN1
{
    public class CustoDeFabricacaoDeUmCarro
    {
        public double CalculaCustoDeFabricacaoDeUmCarro(double percentualDoDistribuidor, double percentualDeImpostos, double custoDeFabrica)
        {
            var custoDeFabricacao =  custoDeFabrica + 
                                    (custoDeFabrica * percentualDoDistribuidor) +
                                    (custoDeFabrica * percentualDeImpostos);

            return custoDeFabricacao;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN4
{
    public class AlgoritimoParaCarregarUmVetor
    {
        public int[] CarregarUmVetor(int[] vetor)
        {         
 
            int i=0;

            while  (i < 5)
            {
                vetor[i] = i++;                
            }
            return vetor;
            
        }
    }
}

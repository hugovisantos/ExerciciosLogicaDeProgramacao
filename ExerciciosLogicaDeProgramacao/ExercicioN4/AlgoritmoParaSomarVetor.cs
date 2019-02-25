using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN4
{
    public class AlgoritmoParaSomarVetor
    {
        public int SomarUmVetor(int[] vetor, int i)
        {
            int somador = 0;

            while (i > 0)
            {
                somador += vetor[i - 1];
                i--;
            }
            return somador;

        }
    }
}

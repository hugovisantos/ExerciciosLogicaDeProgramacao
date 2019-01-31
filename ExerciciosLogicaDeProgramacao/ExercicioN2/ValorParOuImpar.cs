using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN2
{
    public class ValorParOuImpar
    {
        public int Valor { get; set; }

        public bool OValorEPar(int Valor)
        {
            //if (valor % 2 == 0)
            //    return true;
            //else
            //    return false;

            return Valor % 2 == 0;

        }
        public bool OValorEImpar(int valor)
        {
            return valor % 2 != 0;           
        }
    }
}

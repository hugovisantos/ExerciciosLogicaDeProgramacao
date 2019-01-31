using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN2
{
    public class OValorEPositivoOuNegativo
    {
        public bool OValorEPositivo(int valor)
        {
            return valor > 0;
        }

        public bool OValorENegativo(int valor)
        {
            return valor < 0;
        }
        public bool OValorEZero(int valor)
        {
            return valor == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN3
{
    public class MDC_MaximoDivisorComum
    {
        public int CalcularOMDC(int numero1, int numero2)
        {
            int resultado;
            do
            {
                resultado = numero1 % numero2;

                numero1 = numero2;
                numero2 = resultado;
            } while (resultado != 0);

            return numero1;

        }
    }
}

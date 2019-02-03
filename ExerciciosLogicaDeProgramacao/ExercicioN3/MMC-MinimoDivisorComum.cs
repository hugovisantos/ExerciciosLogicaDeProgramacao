using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN3
{
    public class MMC_MinimoDivisorComum
    {
        public int CalcularOMMC(int numero1, int numero2)
        {
            int resultado, a, b;

            a = numero1;
            b = numero2;

            do
            {
                resultado = a % b;
                a = b;
                b = resultado;

            } while (resultado != 0);

            return (numero1*numero2) / a;
        }

    }
}

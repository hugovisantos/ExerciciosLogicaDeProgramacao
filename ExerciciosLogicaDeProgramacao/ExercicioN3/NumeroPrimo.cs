using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN3
{
    public class NumeroPrimo
    {
        public bool CalcularSeONumeroEPrimo(int numero)
        {
            bool primo = true;
            int fator = numero / 2;
            int i = 0;
            for (i = 2; i <= fator; i++)
            {
                if ((numero % i) == 0)
                    primo = false;
            }
            return primo;
        }
    }
}

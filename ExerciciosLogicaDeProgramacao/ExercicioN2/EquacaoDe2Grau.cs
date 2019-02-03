using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN2
{
    public class EquacaoDe2Grau
    {
        public (double, double) FormulaDeBhaskara(int a, int b, int c)
        {
            
            var x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a); 

            var x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            return (x1, x2);

        }

    }
}

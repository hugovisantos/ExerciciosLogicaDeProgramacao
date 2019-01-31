using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN1
{
    public class ReajusteDeSalario
    {
        public double CalcularReajusteDeSalario(double salario, double reajuste)
        {

            var novoSalario = salario + (salario * reajuste);
            return novoSalario;
        }
    }
}

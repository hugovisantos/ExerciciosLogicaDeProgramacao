using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN1
{
    public class JurosSimples
    {
        public double CalcularJurosSimples(double capital, double taxaDeEmprestimo, double periodos)
        {
            var juros = capital * taxaDeEmprestimo * periodos;

            return juros;           
        }
    }
}

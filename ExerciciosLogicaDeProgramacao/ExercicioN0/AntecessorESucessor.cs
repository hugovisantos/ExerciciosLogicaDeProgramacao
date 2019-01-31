using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN0
{
    public class AntecessorESucessor
    {
        public (int, int) ExibeAntecessorESucessor(int numeroQualquer)
        {
            var antecessor = numeroQualquer - 1;
            var sucessor = numeroQualquer + 1;
            return (antecessor, sucessor);
        }
        public int ExibeAntecessor(int numeroQualquer)
        {
            var antecessor = numeroQualquer - 1;
            return antecessor;
        }
        public int ExibeSucessor (int numeroQualquer)
        {
            var sucessor = numeroQualquer + 1;
            return sucessor;
        }
    }
}

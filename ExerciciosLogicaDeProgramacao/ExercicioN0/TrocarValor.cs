using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN0
{
    public class TrocarValor
    {
        public void Alterar()
        {
            var aux = this.A;
            this.A = this.B;
            this.B = aux;
            
        }

        public int A { get; set; } 
        public int B { get; set; }



    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosLogicaDeProgramacao.ExercicioN3
{
    public class SomarDigitos
    {
        public int SomaOsDigitosDeUmNumero(int numero)
        {
            var somadorDeNumeros = 0;

            while(numero != 0)
            {
                somadorDeNumeros += numero % 10;
                numero = numero / 10;
            }
            return somadorDeNumeros;
        }
    }
}

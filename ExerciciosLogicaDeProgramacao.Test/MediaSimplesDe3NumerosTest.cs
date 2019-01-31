using ExerciciosLogicaDeProgramacao.ExercicioN0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class MediaSimplesDe3NumerosTest
    {
        [Fact]
        public void Test1()
        {
            var mediaSimplesDe3Numeros = new MediaSimplesDe3Numeros();

            var a = 1;
            var b = 2;
            var c = 3;
            var media = mediaSimplesDe3Numeros.CalcularMedia(a, b, c);

            Assert.Equal(2, media);
            

        }
    }
}

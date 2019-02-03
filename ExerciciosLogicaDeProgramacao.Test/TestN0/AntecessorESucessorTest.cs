using ExerciciosLogicaDeProgramacao.ExercicioN0;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExerciciosLogicaDeProgramacao.Test
{
    public class AntecessorESucessorTest
    {
        [Fact]
        public void Test1()
        {
            var antecessorESucessor = new AntecessorESucessor();

            var numeroQualquer = 4;            
            var (antecessor, sucessor) = antecessorESucessor.ExibeAntecessorESucessor(numeroQualquer);

            Assert.Equal(3, antecessor);
            Assert.Equal(5, sucessor);
            
        }
        [Fact]
        public void Test2()
        {
            var antecessorESucessor = new AntecessorESucessor();

            var numeroQualquer = 10;
            var antecessor = antecessorESucessor.ExibeAntecessor(numeroQualquer);
            var sucessor = antecessorESucessor.ExibeSucessor(numeroQualquer);

            Assert.Equal(9, antecessor);
            Assert.Equal(11, sucessor);

        }
    }
}

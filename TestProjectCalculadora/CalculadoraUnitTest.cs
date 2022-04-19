using System;
using Xunit;
using calculadora;
using calculadora.utilidades;


namespace TestProjectCalculadora
{
    public class CalculadoraUnitTest
    {
        [Fact]
        public void Test_Resta()
        {
            //ARRANGE
            int primernumero = 60;
            int segundonumero = 5;
            
            //ACT
            Calculadora miCalculadora = new Calculadora();
            int resultado = miCalculadora.Restar(primernumero, segundonumero);
            
            //ASSERT
        }
    }
}

using System;
using Xunit;
using calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProjectCalculadora
{
    public class CalculadoraUnitTest
    {
        [Fact]
        public int Test1(int numero1, int numero2)
        {
            int resultado = numero1- numero2;
            return resultado;
        }
    

    
    }
}

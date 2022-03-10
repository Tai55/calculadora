using System;
using calculadora.utilidades.enumerado;
using calculadora.utilidades.calculadoraservice;

namespace calculadora.utilidades.programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraService calculadora = new CalculadoraService();
            calculadora.Ejecutar();
        }    
    }
}

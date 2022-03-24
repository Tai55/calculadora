using System;
using calculadora.utilidades;


namespace calculadora
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

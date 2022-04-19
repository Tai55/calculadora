using System;
using System.Collections.Generic;

namespace calculadora.utilidades
{
    public class Calculadora
    {    
    List <string> operaciones = new List<string>();
    
        public int Sumar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");
            operaciones.Add($"El resultado de la suma es: {resultado}");
            return resultado;
        }

        public int Restar(int numero1, int numero2)
        {
            int resultado = numero1- numero2;
            Console.WriteLine($"El resultado de la resta es: {resultado}");
            operaciones.Add($"El resultado de la resta es: {resultado}");
            return resultado;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
            operaciones.Add($"El resultado de la resta es: {resultado}");
            return resultado;
        }
   
        public int Dividir(int numero1, int numero2)
        {
            int resultado = numero1/numero2;
            Console.WriteLine($"El resultado de la división es: {resultado}");  
            operaciones.Add($"El resultado de la división es: {resultado}"); 
            return resultado;
        }
        public double Potencia(int numero1, int numero2)
        {
            double resultado = Math.Pow(numero1,numero2);
            Console.WriteLine($"El resultado de la potencia es: {resultado}");
            operaciones.Add($"El resultado de la división es: {resultado}");
            return resultado;
        }

        public void VerListaOperaciones()
        {
            foreach (string operacion in operaciones)
            {
                Console.WriteLine("Las operaciones previas han sido las siguientes:");
                Console.WriteLine(operacion);
            }
        }
    }
}



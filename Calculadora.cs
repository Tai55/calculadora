using System;

namespace calculadora
{
    class Calculadora
    {    
    public int Sumar(int numero1, int numero2)
    {
        int resultado = numero1 + numero2;
        Console.WriteLine($"El resultado de la suma: {resultado}");
        return resultado;
    }

    public int Restar(int numero1, int numero2)
    {
        int resultado = numero1- numero2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
        return resultado;
    }

    public int Multiplicar(int numero1, int numero2)
    {
        int resultado = numero1 * numero2;
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        return resultado;
    }
   
    public int Dividir(int numero1, int numero2)
    {
        int resultado = numero1/numero2;
        Console.WriteLine($"El resultado de la división es: {resultado}");   
        return resultado;
    }

    } 
}



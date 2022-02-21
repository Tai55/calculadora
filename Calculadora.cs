using System;

namespace calculadora
{
    class calculadora
    {
        int num1=0;
        int num2=0;
        int resultado=0;
        
    public void Sumar(int num1, int num2)
    {
        int resultado = num1 + num2;
        Console.WriteLine($"El resultado de la suma: {resultado}");
        Console.ReadLine();
    }

    public void Restar(int num1, int num2)
    {
        int resultado = num1- num2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
        Console.ReadLine();
        
    }

    public void Multiplicar(int num1, int num2)
    {
        int resultado = num1 * num2;
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        Console.ReadLine();
        
    }
   
    public void Dividir(int num1, int num2)
    {
        int resultado = num1/num2;
        Console.WriteLine($"El resultado de la división es: {resultado}"); 
        Console.ReadLine();
        
    }

    } 
}



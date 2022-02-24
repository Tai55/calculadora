using System;

namespace calculadora
{
    class Calculadora
    {
        int numero1=0;
        int numero2=0;
        int resultado=0;
        
    public void Sumar(int numero1, int numero2)
    {
        int resultado = numero1 + numero2;
        Console.WriteLine($"El resultado de la suma: {resultado}");
        Console.ReadLine();
    }

    public void Restar(int numero1, int numero2)
    {
        int resultado = numero1- numero2;
        Console.WriteLine($"El resultado de la resta es: {resultado}");
        Console.ReadLine();
        
    }

    public void Multiplicar(int numero1, int numero2)
    {
        int resultado = numero1 * numero2;
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        Console.ReadLine();
        
    }
   
    public void Dividir(int numero1, int numero2)
    {
        int resultado = numero1/numero2;
        Console.WriteLine($"El resultado de la división es: {resultado}"); 
        Console.ReadLine();  
    }

    } 
}



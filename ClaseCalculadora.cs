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
        Console.WriteLine("El resultado es: " + resultado);
    }

    public void Restar(int num1, int num2)
    {
        int resultado = num1- num2;
        Console.WriteLine("El resultado es: " + resultado);
    }

    public void Multiplicar(int num1, int num2)
    {
        int resultado = num1 * num2;
        Console.WriteLine("El resultado es: " + resultado);
    }
   
    public void Dividir(int num1, int num2)
    {
        int resultado = num1/num2;
        Console.WriteLine("El resultado es: " + resultado); 
    }

    } 
}



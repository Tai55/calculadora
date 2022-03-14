using System;
using calculadora.utilidades;

namespace calculadora.utilidades
{
    class CalculadoraService
    {
        public void Ejecutar()
        {
            
            Calculadora calculadora = new Calculadora();
            int opcion = 0;
            int primernumero = 0;
            int segundonumero = 0;
            

        while (opcion != 5)
        {
            Console.Clear();
            opcion = Menu();
            
            if (opcion == 5)
            {
                Console.WriteLine("Nos vemos proximamente, presione ENTER para salir");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Antes de comenzar a calcular, escriba dos números");
            Console.WriteLine("Introduzca el número que desee:");
            primernumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca un segundo número");
            segundonumero = Int32.Parse(Console.ReadLine());

            switch (Opciones)
            {
                case Opciones.Sumar:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de sumar");
                calculadora.Sumar(primernumero, segundonumero);
                break;
                
            
                case Opciones.Restar:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de restar");
                calculadora.Restar(primernumero, segundonumero);
                break;
            
                case Opciones.Multiplicar: 
            
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de multiplicar");
                calculadora.Multiplicar(primernumero, segundonumero);
                break;
                
                case Opciones.Dividir:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de dividir");
                calculadora.Dividir(primernumero, segundonumero);
                break;
            }
            Console.ReadLine();
        }

           
    }
        public static Opciones Menu()
        {
            Console.Title = "CALCULADORA";
            Console.WriteLine("BIENVENID@ A LA CALCULADORA DE MARÍA Y JESÚS");
            Console.WriteLine("--------------------------------------------");
            opcionesDelMenu();
            Opciones opcion ;
            try 
            {
                opcion = (Opciones)Int32.Parse(Console.ReadLine());
                Console.WriteLine("La opción elegida es la: " + opcion);
                Console.WriteLine("");

                while (opcionMenu(opcion)==false)
            {
               Console.Clear();
               Console.WriteLine("Seleccione una opcion valida");
               opcionesDelMenu();
               opcion = (Opciones)Int32.Parse(Console.ReadLine()); 
            }
            return opcion;

            }
            catch (Exception)
            {
                Console.WriteLine("El valor introducido no es un valor númerico");
                // TO DO: esto hay que cambiarlo por la opcion Salir. 
                return Opciones.Sumar;  
            }

            
        }
        public static bool opcionMenu(Opciones opcion)
        {
            if ((opcion == Opciones.Sumar ) || (opcion == Opciones.Restar) || (opcion == Opciones.Multiplicar) || (opcion == Opciones.Dividir) || (opcion == 5))
            {
                return true;
            }
            
            else 
                return false;
        }
        public static void opcionesDelMenu()
        {
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Cerrar calculadora");
            Console.WriteLine("Elija una opción");
        }

    }
}

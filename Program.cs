using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
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

            switch (opcion)
            {
                case 1:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de sumar");
                calculadora.Sumar(primernumero, segundonumero);
                break;
                
            
                case 2:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de restar");
                calculadora.Restar(primernumero, segundonumero);
                break;
            
                case 3: 
            
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de multiplicar");
                calculadora.Multiplicar(primernumero, segundonumero);
                break;
                
                case 4:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de dividir");
                calculadora.Dividir(primernumero, segundonumero);
                break;
            }
        }
           
    }
        public static int Menu()
        {
            Console.Title = "CALCULADORA";
            Console.WriteLine("BIENVENID@ A LA CALCULADORA DE MARÍA Y JESÚS");
            Console.WriteLine("--------------------------------------------");
            opcionesDelMenu();
            int opcion = 0;
            try 
            {
                opcion = Int32.Parse(Console.ReadLine());
                Console.WriteLine("La opción elegida es la: " + opcion);
                Console.WriteLine("");
            }
            catch (Exception)
            {
                Console.WriteLine("El valor introducido no es un valor númerico");
            }

            while (opcionMenu(opcion)==false)
            {
               Console.Clear();
               Console.WriteLine("Seleccione una opcion valida");
               opcionesDelMenu();
               opcion = Int32.Parse(Console.ReadLine()); 
            }
            return opcion;
        }
        public static bool opcionMenu(int opcion)
        {
            if ((opcion == 1) || (opcion == 2) || (opcion == 3) || (opcion == 4) || (opcion == 5))
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

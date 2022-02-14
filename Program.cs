using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            calculadora calculadora = new calculadora();
            int opcion = 0;
            int primernumero = 0;
            int segundonumero = 0;
            int resultado = 0;
            opcion = Menu();
            Console.WriteLine("Introduzca un primer valor: ");
            primernumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca un segundo valor: ");
            segundonumero = Int32.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de sumar");
                calculadora.Sumar(primernumero, segundonumero);
            }
            else if (opcion == 2)
            {
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de restar");
                calculadora.Restar(primernumero, segundonumero);
            }
            else if (opcion == 3)
            {
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de multiplicar");
                calculadora.Multiplicar(primernumero, segundonumero);
            }
            else if (opcion == 4)
            {
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de dividir");
                calculadora.Dividir(primernumero, segundonumero);
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
            }
            catch (Exception)
            {
                Console.WriteLine("El valor introducido no es un valor númerico");
            }

            while (OpcionMenu(opcion)==false)
            {
               Console.Clear();
               Console.WriteLine("Seleccione una opcion valida");
               opcionesDelMenu();
               opcion = Int32.Parse(Console.ReadLine()); 
            }
            return opcion;
        }
        public static bool OpcionMenu(int opcion)
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
        }

    }
}

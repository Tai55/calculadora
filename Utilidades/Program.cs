using System;
using calculadora.utilidades.enumerado;

namespace calculadora.utilidades.programa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculadora calculadora = new Calculadora();
            int opcion = 0;
            int primerNumero = 0;
            int segundoNumero = 0;
            

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
            primerNumero = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca un segundo número");
            segundoNumero = Int32.Parse(Console.ReadLine());

            switch ((Opciones)opcion)
            {
                case Opciones.Sumar:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de sumar");
                calculadora.Sumar(primerNumero, segundoNumero);
                break;

                case Opciones.Restar:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de restar");
                calculadora.Restar(primerNumero, segundoNumero);

                break;

                case Opciones.Multiplicar: 
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de multiplicar");
                calculadora.Multiplicar(primerNumero, segundoNumero);
                break;

                case Opciones.Dividir:
                Console.Clear();
                Console.WriteLine("Ha selecionado la opcion de dividir");
                calculadora.Dividir(primerNumero, segundoNumero);
                break;
                
            }
            Console.ReadLine();
        }   
    }
        public static int Menu()
        {
            Console.Title = "CALCULADORA";
            Console.WriteLine("BIENVENID@ A LA CALCULADORA DE MARÍA Y JESÚS");
            Console.WriteLine("--------------------------------------------");
            OpcionesDelMenu();
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

            while (EleccionUsuarionMenu(opcion)==false)
            {
               Console.Clear();
               Console.WriteLine("Seleccione una opcion valida");
               OpcionesDelMenu();
               opcion = Int32.Parse(Console.ReadLine()); 
            }
            return opcion;
        }
        public static bool EleccionUsuarionMenu(int opcion)
        {
            if ((opcion == 1) || (opcion == 2) || (opcion == 3) || (opcion == 4) || (opcion == 5))
            {
                return true;
            }
            
            else 
                return false;
        }
        public static void OpcionesDelMenu()
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

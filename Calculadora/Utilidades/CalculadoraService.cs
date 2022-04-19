using System;

namespace calculadora.utilidades
{
    class CalculadoraService
    {
        public void Ejecutar()
        {
            
            Calculadora calculadora = new Calculadora();
            Opciones opcion = 0 ;
            int primernumero = 0;
            int segundonumero = 0;
            

            do 
            {
                Console.Clear();
                opcion = Menu();

                Console.WriteLine("Antes de comenzar a calcular, escriba dos números");
                Console.WriteLine("Introduzca el número que desee:");
                primernumero = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca un segundo número");
                segundonumero = Int32.Parse(Console.ReadLine());

                switch (opcion)
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
                    
                    case Opciones.Potencia:
                        Console.Clear();
                        Console.WriteLine("Has seleccionado la opcion de potencia");
                        calculadora.Potencia(primernumero, segundonumero);
                    break;

                    case Opciones.Registro:
                        Console.Clear();
                        calculadora.VerListaOperaciones();
                    break;
                    
                    case Opciones.Salir:
                        Console.Clear();
                        Console.WriteLine("Nos vemos proximamente, presione ENTER PARA SALIR");
                        Console.ReadLine();
                    break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
            while(opcion != Opciones.Salir);
           

            //Console.ReadLine();
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
                return Opciones.Salir;  
            }

            
        }
        public static bool opcionMenu(Opciones opcion)
        {
            if ((opcion == Opciones.Sumar ) || (opcion == Opciones.Restar) || (opcion == Opciones.Multiplicar) || (opcion == Opciones.Dividir) || (opcion == Opciones.Salir))
            {
                return true;
            }
            
            else 
                return false;
        }
        public static void opcionesDelMenu()
        {
            Opciones opciones = Opciones.Salir; 
            foreach (var opcion in Enum.GetNames(opciones.GetType()))
            {
                var opcionValue = (int)Enum.Parse(opciones.GetType(), opcion);
                Console.WriteLine($"{opcionValue}. {opcion}");
            }

           /* Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Cerrar calculadora");
            Console.WriteLine("Elija una opción");  */
        }

    }
}

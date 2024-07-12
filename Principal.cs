using System;
using System.Security.AccessControl;
using libreriaClase;

namespace libreria
{

    class Pricipal{
        static void Main(){

            string opcion = mostrarMenu();

            while ( opcion != "9") {

            if (opcion == "1"){

                crearPersona();
            } 
            else
            {
                Console.WriteLine("Opción Incorrecta...");
                Console.ReadKey();
            }

            opcion = mostrarMenu();

            }

        }

         public static void crearPersona(){

            Console.Clear();
            Persona p1 = new Persona();

            Console.WriteLine("Ingreso de Personas");
            Console.WriteLine("-------------------");
            Console.WriteLine("");

            Console.Write("Ingrese Apellido: ");
            p1.Apellido = Console.ReadLine();

            Console.Write("Ingrese Nombre: ");
            p1.Nombre = Console.ReadLine();

            Console.Write("Ingrese DNI: ");
            p1.DNI = Convert.ToInt32(Console.ReadLine());            
            

            Console.Write("Ingrese Fecha Nacimiento: ");
            p1.FechaNacimiento = Console.ReadLine();

        }


        public static string mostrarMenu(){

            string opcion;

            Console.Clear();

            Console.WriteLine("Menú");
            Console.WriteLine("-----");

            Console.WriteLine("");
            Console.WriteLine("1.- Crear Alumno");
            Console.WriteLine("");
            Console.Write("Elija una opción: ");

            opcion = Console.ReadLine();

            return opcion;


        }
    }


    
}
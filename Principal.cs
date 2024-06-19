using System;
using libreriaClase;

namespace libreria
{

    class Pricipal{

        static void Main(){

            Persona p1 = new Persona("Diego","1/1/1",5666544);

            Persona p2 = new Persona();

            Console.WriteLine(p1.caminar());

            p1.mostrarPersona();


            p2.Nombre = "Martin";

            Console.WriteLine(p2.Nombre);

            p2.mostrarPersona();
            
            Alumno a1 = new Alumno();

            a1.DNI = 23424234;
            a1.Nombre = "Juan";

            a1.mostrarPersona();

        }
    }
    
}
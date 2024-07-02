using System;
using System.Security.AccessControl;
using libreriaClase;

namespace libreria
{

    class Pricipal{

        static void Main(){


            Persona p1 = new Persona("Diego","1/1/1",5666544);
            
            Alumno a1 = new Alumno();
            a1.Nombre = "Juan";

            a1.devolverCurso();
            a1.devolverEdad();

        }
    }
    
}
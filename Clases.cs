namespace libreriaClase{

    class Persona
    {

        private string nombre;
        public string Nombre {get;set;}

        private string fechaNacimiento;
        public string FechaNacimiento {get;set;}
        private int dni;
        public int DNI {get;set;}

       

        public  Persona(string rNombre, string rFechaNacimiento, int rDni){
            nombre = rNombre;
            fechaNacimiento = rFechaNacimiento;
            dni = rDni;

        }

        public Persona(){
            
        }
        public string caminar(){

            return "Caminando....";

        }

        public void mostrarPersona(){
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Fecha Nacimiento: {0}", FechaNacimiento);
            Console.WriteLine("DNI: {0}", DNI);
        }

    }


    class Alumno : Persona {

        private int legajo;
        private string curso;

        private int[] notas;


        public void estudiar(){
            Console.WriteLine("Estudiando....");
        }
    }

}
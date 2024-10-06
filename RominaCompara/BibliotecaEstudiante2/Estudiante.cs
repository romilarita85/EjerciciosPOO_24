//Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:
//Diagrama de clases

//La clase Estudiante:

//Tendrá un constructor estático que inicializará el atributo estático random.
//Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
//El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
//El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
//El método privado CalcularPromedio retornará el promedio de las dos notas.
//El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
//El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
//Nombre, apellido y legajo.
//Nota del primer y segundo parcial.
//Promedio.
//Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".

//Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
//Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
//Mostrar los datos de todos los alumnos.
using System.Net.Mail;
using System.Text;
using System.Transactions;

namespace BibliotecaEstudiante2
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random rand;

        
        //Tendrá un constructor estático que inicializará el atributo estático random.
        static Estudiante() 
        {
            Estudiante.rand = new Random();
        }
        //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        //El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
        public void SetNotaPrimerParcial(int nota) 
        {
            this.notaPrimerParcial = nota;
        }
        //El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        public string Apellido 
        {
            get 
            { 
                return this.apellido; 
            }
            set 
            { 
                this.apellido = value; 
            } 
        }
        public string Legajo 
        {
            get 
            { 
                return this.legajo; 
            }
            set
            {
                this.legajo = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
               
                this.nombre = value;
            }
        }
        public int NotaPrimerParcial 
        {
            get 
            {
                return notaPrimerParcial;
            } 
            set 
            {  
                this.notaPrimerParcial = value; 
            } 
        }
        public int NotaSegundoParcial 
        { 
            get
            {
               return this.notaSegundoParcial; 
            }

            set
            { 
             
                this.notaSegundoParcial = value;
            }
   
        }
        public static Random Rand 
        {
            get
            {
                return Estudiante.rand;
            }
            set
            {
                Estudiante.rand = value;
            }    
        }

        //El método privado CalcularPromedio retornará el promedio de las dos notas.
        private float CalcularPromedio() 
        {
            return ((float)this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }
  //El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 incluidos siempre
        //y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.

        private double CalcularNotaFinal() 
        {
            double notaFinal;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = Estudiante.rand.Next(6, 10);
            }
            else 
            {
                notaFinal = -1;
            }


            return notaFinal;
        }

        //El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        //Nombre, apellido y legajo.
        //Nota del primer y segundo parcial.
        //Promedio.
        //Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
        public string Mostrar() 
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine($"Nombre: {this.nombre} Apellido: {this.apellido} - Legajo: {this.legajo}.");
            stb.AppendLine($"Nota del primer parcial: {this.notaPrimerParcial} -Nota Segundo parcial: {this.notaSegundoParcial}");
            stb.AppendLine($"Promedio: {CalcularPromedio()}");

            double notaFinal = this.CalcularNotaFinal();
           
            if (notaFinal != -1)
            {
                stb.AppendLine($"Nota final: {notaFinal}" );
            }
            else
            {
                stb.AppendLine("Alumno desaprobado");
            }
            return stb.ToString();
        }       
    }
}

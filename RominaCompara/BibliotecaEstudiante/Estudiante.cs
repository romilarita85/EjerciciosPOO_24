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

using System.Text;

namespace BibliotecaEstudiante
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random rnd;
        //Tendrá un constructor estático que inicializará el atributo estático random.
        static Estudiante() 
        {
            Estudiante.rnd = new Random();  
        }
        //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
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
        //El método privado CalcularPromedio retornará el promedio de las dos notas.
        private float CalcularPromedio() 
        {

            return ((float)this.notaPrimerParcial + this.notaSegundoParcial ) / 2;
        
        }
        //El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10
        //incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        //caso contrario la inicializará con el valor -1.
        private double CalcularNotaFinal() 
        {
            double resultado = -1;
          
            if ((this.notaPrimerParcial >= 4) && (this.notaSegundoParcial >= 4))
            {
                 resultado = Estudiante.rnd.Next(6, 10);//numero aleatorio entre 6 y 10
            }
            
            return resultado;
        }
        //otra forma:
        private double CalcularNotaFinal2()
        {
            double resultado;

            if ((this.notaPrimerParcial >= 4) && (this.notaSegundoParcial >= 4))
            {
                resultado = Estudiante.rnd.Next(6, 10);//numero aleatorio entre 6 y 10
            }
            else 
            {
                resultado = -1; //no se pudo
            }

            return resultado;
        }

        //El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        //Nombre, apellido y legajo.
        //Nota del primer y segundo parcial.
        //Promedio.
        //Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
        public string Mostrar()
        {
            
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Alumno: {this.nombre},{this.apellido} - Legajo n°: {this.legajo}");
            sb.AppendLine($"Nota 1° parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota 2° parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            
            double notaFinal = this.CalcularNotaFinal();

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }


    }
}

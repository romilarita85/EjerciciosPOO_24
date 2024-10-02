//Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
//Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
//Mostrar los datos de todos los alumnos.
using BibliotecaEstudiante;

namespace TesteoEstudiante01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Carlos", "Gomez", "123");
            Estudiante e2 = new Estudiante("Sofia", "Reyes", "124");
            Estudiante e3 = new Estudiante("Carlos", "Gomez", "125");

            e1.SetNotaPrimerParcial(8);
            e1.SetNotaSegundoParcial(9);

            e2.SetNotaPrimerParcial(7);
            e2.SetNotaSegundoParcial(7);
           
            e3.SetNotaPrimerParcial(2);
            e3.SetNotaSegundoParcial(3);
           
            Console.WriteLine("Datos primer estudiante: ");
            Console.WriteLine(e1.Mostrar());
            
            Console.WriteLine("Datos segundo estudiante: ");
            Console.WriteLine(e2.Mostrar());
            
            Console.WriteLine("Datos tercer estudiante: ");
            Console.WriteLine(e3.Mostrar());
        }
    }
}

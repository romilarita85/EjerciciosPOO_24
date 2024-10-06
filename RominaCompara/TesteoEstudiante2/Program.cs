//Crear tres instancias de la clase Estudiante (tres objetos) en el método
// Main.
// ● Cargarlas notas del primer y segundo parcial a todos los alumnos. Dos
// deberán estar aprobados y uno desaprobado.
// ● Mostrar los datos de todos los alumnos
using BibliotecaEstudiante2;

namespace TesteoEstudiante2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Gomez", "445", "Rocio");
            Estudiante estudiante2 = new Estudiante("Fernandez", "445", "Carlos");
            Estudiante estudiante3 = new Estudiante("Richi", "445", "Leonel");

            estudiante1.NotaPrimerParcial = 3;
            estudiante1.NotaSegundoParcial = 4;

            estudiante2.NotaPrimerParcial = 5;
            estudiante2.NotaSegundoParcial = 6;

            estudiante3.NotaPrimerParcial = 7;
            estudiante3.NotaSegundoParcial = 10;

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine("**********************************************");
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine("**********************************************");
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}

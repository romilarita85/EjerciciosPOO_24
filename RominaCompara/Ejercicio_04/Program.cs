// A partir del ingreso del nombre de un alumno y su nota, mostrar el nombre del
//alumno y su condición frente al examen:
//○ Si la nota está entre 1 y 3: el alumno está desaprobado.
//○ Si la nota está entre 4 y 5: el alumno está regularizado.
//○ Si la nota está entre 6 y 10: el alumno está promocionado
namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            int nota;
           

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su nota (entre 1 y 10):");
            //nota = double.Parse(Console.ReadLine());


            if (int.TryParse(Console.ReadLine(), out nota))
            {
                if (nota >= 1 && nota <= 10)
                {
                    if (nota >= 6 && nota <= 10)
                    {
                        Console.WriteLine($"El alumno/a {nombre} esta promocionado");
                    }
                    else 
                    {
                        if (nota >= 4 && nota < 6)
                        {
                            Console.WriteLine($"El alumno/a {nombre} esta regularizado");
                        }
                        else
                        {
                            if (nota >= 1 && nota < 4)
                            {
                                Console.WriteLine($"El alumno/a {nombre} esta desaprobado");
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine($"Debe ingresar una nota entre 1 y 10");
                }

            }
            else 
            {
                Console.WriteLine($"Recuerde que debe ingresar un numero (del 1 al 10) para la nota");
            }
            

        }
    }
}

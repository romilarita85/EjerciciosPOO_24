//Crear un menu de opciones que permita:
//a-Cargar un array de caracteres en minusculas.Normalizar el ingreso de caracteres
//con metodos de string
//b-Contar vocales dentro del vector (cuantas a,e,i,o,u)
//c-Ordenar el array de manera alfabetica y mostrarlo.Corregir codigo.
//d-Reemplazar la vocal ingresada por teclado (validar q sea una vocal), por el caracter $
//e-Mostrar el array de reversa.
//Crear una clase con metodos estaticos para todos los requerimientos del examen y llamarlos desde el main
using BibliotecaDeVectores;

namespace Examen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            char[] arrayCaracteres = new char[6];

            string seguir = "si";


            while (seguir.ToLower() == "si")
            {
           
                //1-Cargar un array de caracteres en minuscula.Normalizar el ingreso de caracteres con metodo to string

                Console.WriteLine("**********************Menú de opciones*************************");
                Console.WriteLine("1.Cargar un array de caracteres en minusculas. ");
                Console.WriteLine("2.Contar vocales dentro del vector (cuantas a,e,i,o,u)");
                Console.WriteLine("3.Ordenar el array de manera alfabetica y mostrarlo");
                Console.WriteLine("4.Reemplazar la vocal ingresada por teclado por el caracter $");
                Console.WriteLine("5. Mostrar el array de reversa");
                Console.WriteLine("6.Salir");
                Console.Write("Selecciona una opción para  continuar: ");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        //a-Cargar un array de caracteres en minusculas.
                        //Normalizar el ingreso de caracteres con metodos de string
                        Vector.CargarArray1(arrayCaracteres);
                        
                        Console.WriteLine("Contenido del array");

                        foreach (char c in arrayCaracteres)
                        {
                            Console.WriteLine(c);
                        }


                        //Vector.MostrarChar(arrayCaracteres);

                        break;
                    case 2:
                        //b-Contar vocales dentro del vector (cuantas a,e,i,o,u)
                        int cantVocales = 0;
                        cantVocales = Vector.ContarVocales(arrayCaracteres);

                        Console.WriteLine($"La cantidad de vocales del array es: {cantVocales}");

                        break;
                    case 3:
                        //c-Ordenar el array de manera alfabetica y mostrarlo.Corregir codigo.

                        Vector.OrdenarArrayCorregido(arrayCaracteres);
                        Vector.MostrarChar(arrayCaracteres);

                        break;
                    case 4:
                        //Reemplazar la vocal ingresada por teclado(validar que sea una vocal), por el caracter $.
                        //Mostrar el array
                        Vector.ReemplazarVocal(arrayCaracteres);
                        Vector.MostrarChar(arrayCaracteres);
                        break;
                    case 5:
                        //Mostrar el array de reversa;
                        Vector.ArrayReversa(arrayCaracteres);
                        Vector.MostrarChar(arrayCaracteres);
                        break;
                    case 6:
                        Console.WriteLine("Saliendo. del sistema..");
                        return;
                    //salir

                    default:
                        Console.WriteLine("La opcion ingresada es invalida. Vuelva a intentarlo....");
                        break;
                }
                //Console.WriteLine("Desea seguir: si/no");
                //seguir = Console.ReadLine();
            }
        }
    }
}

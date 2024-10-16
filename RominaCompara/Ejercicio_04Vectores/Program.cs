//EJERCICIO 4:
//Crear un menú de opciones que permita:
// a.Cargar un array de caracteres. Recomendación: utilizar el
// método toCharArray().
// b. Ordenar vector.
// c. Contar vocales dentro del vector. (Cuantas a, e, i, o y u)
// d. Reemplazar consonantes por el carácter ‘*’ y mostrar
using System.Numerics;
namespace Ejercicio_04Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arrayCaracteres = null;
            string seguir = "si";//variable de control
            int opcion;
            while (seguir.ToLower() == "si")
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("1. Cargar un array de caracteres");
                Console.WriteLine("2. Ordenar el array");
                Console.WriteLine("3. Contar vocales en el array");
                Console.WriteLine("4. Reemplazar consonantes por '*' y mostrar");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce una cadena de caracteres: ");
                        string palabra = Console.ReadLine();//lee la palabra
                        arrayCaracteres = palabra.ToCharArray();// convierte a char
                        Console.WriteLine("El array fue cargado.");
                        break;

                    case 2:
                        if (arrayCaracteres != null)
                        {
                            Array.Sort(arrayCaracteres);
                            string arrayOrdenado = new string(arrayCaracteres); //creo instancia de string
                           
                            Console.WriteLine($"Array ordenado: {arrayOrdenado}");
                        }
                        else
                        {
                            Console.WriteLine("Error!! Debes cargar el array.");
                        }
                        break;

                    case 3:// c. Contar vocales dentro del vector. (Cuantas a, e, i, o y u)
                        if (arrayCaracteres != null)//verifico si es nulo
                        {
                            int contadorVocales = 0;
                            foreach (char caracter in arrayCaracteres)
                            {
                                if ("aeiouAEIOU".Contains(caracter))
                                {
                                    contadorVocales++;
                                }
                            }
                            Console.WriteLine($"Cantidad de vocales del array: {contadorVocales}");
                        }
                        else
                        {
                            Console.WriteLine("Error!! Debes cargar el array.");
                        }
                        break;

                    case 4:// d. Reemplazar consonantes por el carácter ‘*’ y mostrar
                        if (arrayCaracteres != null) //si es nulo?
                        {
                            char[] arrayModificado = new char[arrayCaracteres.Length];
                            for (int i = 0; i < arrayCaracteres.Length; i++)
                            {
                                if ("aeiouAEIOU".Contains(arrayCaracteres[i]))
                                {
                                    arrayModificado[i] = arrayCaracteres[i]; // mantiene vocales
                                }
                                else
                                {
                                    arrayModificado[i] = '*'; // reemplaza consonantes
                                }
                            }
                            string modificado = new string(arrayModificado);
                            Console.WriteLine($"El Array modificado es: {modificado}");
                           
                        }
                        else
                        {
                            Console.WriteLine("Primero debes cargar el array.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo...");
                        return;

                    default:
                        Console.WriteLine("La opción es invalida!! Por favor, elige otra opción.");
                        break;
                }

                Console.WriteLine();
            }

        }
        static void CargarArrayCaracteres(char[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese el carácter {i + 1}: ");
                array[i] = Console.ReadKey().KeyChar; // Leer un carácter
                Console.WriteLine(); // Salto de línea
            }

        }
        static void MostrarArrayChar(char[] array) 
        {
            foreach (char c in array)
            {
                Console.Write(c + " "); // Imprimir cada carácter seguido de un espacio
            }
        }
        static void OrdenarArray(char[] array) 
        {
            int n = array.Length;

            // Ordenar el array usando el algoritmo burbuja
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Intercambiar los caracteres
                        char temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}

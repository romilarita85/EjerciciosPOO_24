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
                    case 1:// a.Cargar un array de caracteres. Recomendación: utilizar el
                           // método toCharArray().
                        arrayCaracteres = CargarArray();
                        Console.WriteLine("Contenido del array de caracteres: ");
                        MostrarArrayChar(arrayCaracteres);

                        break;

                    case 2:// b. Ordenar vector.
                        if (arrayCaracteres != null)
                        {
                            Console.WriteLine("Mostrando el array ordenado: ");
                            OrdenarArray(arrayCaracteres);
                            MostrarArrayChar(arrayCaracteres);
                        }
                        else
                        {
                            Console.WriteLine("Primero debes cargar el array.");
                        }
                        
                        break;

                    case 3:// c. Contar vocales dentro del vector. (Cuantas a, e, i, o y u)// ok
                       
                        if (arrayCaracteres != null)
                        {
                            int cantA = 0;
                            int cantE = 0;
                            int cantI = 0;
                            int cantO = 0;
                            int cantU = 0;

                            cantA = ContarLetraVocal2(arrayCaracteres, 'a');
                            cantE = ContarLetraVocal2(arrayCaracteres, 'e');
                            cantI = ContarLetraVocal2(arrayCaracteres, 'i');
                            cantO = ContarLetraVocal2(arrayCaracteres, 'o');
                            cantU = ContarLetraVocal2(arrayCaracteres, 'u');

                            Console.WriteLine($"La cantidad de letras a: {cantA}");
                            Console.WriteLine($"La cantidad de letras e: {cantE}");
                            Console.WriteLine($"La cantidad de letras i: {cantI}");
                            Console.WriteLine($"La cantidad de letras o: {cantO}");
                            Console.WriteLine($"La cantidad de letras u: {cantU}");
                            
                        }
                        else
                        {
                            Console.WriteLine("Primero debes cargar el array.");
                        }
                        break;

                    case 4:// d. Reemplazar consonantes por el carácter ‘*’ y mostrar
                        if (arrayCaracteres != null)
                        {
                            ReemplazarConsonantes(arrayCaracteres);
                            MostrarArrayChar(arrayCaracteres);
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
        public static char[] CargarArray()// no estoy limitado por la cantidad de letras
        {
            string lectura;
            Console.WriteLine("Ingrese una palabra: ");
            lectura = Console.ReadLine();//ReadLine te devuelve un string

            return lectura.ToCharArray();
        }

        public static void MostrarArrayChar(char[] vector) 
        {
            foreach (char c in vector)
            {
                Console.Write(c); 
            }
        }
        public static void OrdenarArray(char[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length ; j++)
                {
                    if (array[i] > array[j])
                    {
                        // Intercambiar los caracteres
                        char aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }
        public static void ReemplazarConsonantes(char[] letras) 
        {
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == 'b' || letras[i] == 'c' || letras[i] == 'd' || letras[i] == 'f' || letras[i] == 'g' || letras[i] == 'h' || letras[i] == 'g'|| letras[i] == 'j'|| letras[i] == 'k'|| letras[i] == 'l'|| letras[i] == 'm' || letras[i] == 'n' ||  letras[i] == 'ñ' || letras[i] == 'p' || letras[i] == 'q'|| letras[i] == 'r'|| letras[i] == 's'|| letras[i] == 't'|| letras[i] == 'v'|| letras[i] == 'w' || letras[i] == 'x'|| letras[i] == 'y'|| letras[i] == 'z')
                {
                    letras[i] = '*';
                }
            }
        }
        //METODO PARA CONTAR VOCALES
        
        public static int ContarLetraVocal(char[] vector, char valorBuscado)
        {
            int contador = 0;//contador se recetea dento del metodo
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == valorBuscado)
                {
                    contador++;

                }
            }
            return contador;
        }
        public static int ContarLetraVocal2(char[] vector, char valorBuscado)
        {
            int contador = 0;//contador se recetea dento del metodo
            foreach (char c in vector)
            {
                if (c == valorBuscado)
                {
                    contador++;
                }
            }
            return contador;
        }
        //public static int ContarVocales(char[] vector)
        //{
        //    int contadorVocales = 0;
        //    for (int i = 0; i < vector.Length; i++)
        //    {
        //        Console.WriteLine(vector[i]);

        //        char letra = char.ToLower(vector[i]);

        //        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        //        {
        //            contadorVocales++;

        //        }
        //    }
        //    return contadorVocales;
        //}
    }
}

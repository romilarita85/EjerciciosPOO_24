//EJERCICIO 2:
//Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.
namespace Ejercicio_02Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            int suma = 0;
            
            vector[0] = 3;
            vector[1] = 10;
            vector[2] = 1;
            vector[3] = 5;
            vector[4] = -2;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
                suma += vector[i];
            }
            Console.WriteLine($"El valor de la suma es: {suma}");

            Console.WriteLine("Con funciones:***************************");
            int[] vectorDeNumeros = new int[5];

            CargarVector(vectorDeNumeros);
            Console.WriteLine("***************************");
            MostrarValores(vectorDeNumeros);

            Console.WriteLine($"La suma de los elementos es: {SumarValores(vectorDeNumeros)}");
            Console.WriteLine($"La suma de los elementos es: {SumarValores1(vectorDeNumeros)}");
            MostrarValores1(vectorDeNumeros);
        }
        public static void CargarVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero {i + 1} de {vector.Length}");
                int numero = int.Parse(Console.ReadLine());
                vector[i] = numero;
            }
        }
        public static int SumarValores(int[] vector)//con for
        {
            int suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            return suma;
        }
        public static int SumarValores1(int[] vector)//foreach
        {
            int suma = 0;
            foreach (int numero in vector)
            {
                suma += numero;
            }
            return suma;
        }

        public static void MostrarValores(int[] vector)//con for
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);

            }

        }
        public static void MostrarValores1(int[] vector)//con foreach
        {
            foreach (int numero in vector)
            {
                Console.WriteLine(numero);
            }

        }
    }
}

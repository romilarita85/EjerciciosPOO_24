//EJERCICIO 1:
//Cargar un vector de enteros de 5 elementos y mostrarlo.
using System.Numerics;

namespace Ejercicio_01Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];

            vector[0] = 23;
            vector[1] = 2;
            vector[2] = -5;
            vector[3] = 56;
            vector[4] = 8;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.WriteLine("Con funciones: ************************");
            //Con funciones********************************
            int[] vectorNumeros = new int[5];

            CargarVector(vectorNumeros);

            Console.WriteLine("************************");
            MostrarVector(vectorNumeros); // con for

            Console.WriteLine("************************");
            MostrarVector1(vectorNumeros);// con foreach
            Console.WriteLine("Mostrando numeros pares:**************");
            MostrarNumerosPares(vectorNumeros);
            Console.WriteLine($"La suma de numeros positivos es :{SumarSoloPositivos(vectorNumeros)}");

            Console.WriteLine("***********Vector ordenado de menor a mayor*************");
            OrdenarVector(vectorNumeros);
            MostrarVector(vectorNumeros);
            Console.WriteLine("***********Vector ordenado de mayor a menor*************");
            OrdenarVector2(vectorNumeros);
            MostrarVector(vectorNumeros);
        }
        static void CargarVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero {i} de {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                vector[i] = numero;
            }
        }
        static void MostrarVector(int[] vector) // con for
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
        static void MostrarVector1(int[] vector)//con foreach
        {
            foreach (int elemento in vector)
            {
                Console.WriteLine(elemento);
            }
        }
        static void MostrarNumerosPares(int[] vector) 
        {
            foreach (int numero in vector)
            {
                if (numero % 2 == 0 && numero != 0) 
                {
                    Console.WriteLine(numero);
                }

            }
        }
        public static int SumarSoloPositivos(int[] vector) 
        {
            int suma = 0;
            foreach (int numero in vector)
            {
                if (numero > 0 ) 
                {
                    suma += numero;
                }
            }
            return suma;
        }
        public static void OrdenarVector(int[] vector) 
        {
            int auxiliar;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j]) 
                    { 
                        auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                    }
                }
               
            }
        }
        public static void OrdenarVector2(int[] vector)
        {
            int auxiliar;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                    }
                }

            }
        }
        public static void OrdenarVectorAscendente(int[] vector)
        {
            int auxiliar;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j]) 
                    {
                        auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                    }
                }
            }
        }

        public static void OrdenarVectorDescendente(int[] vector)
        {
            int auxiliar;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j]) 
                    {
                        auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                    }
                }
            }
        }
    }
}

//EJERCICIO 3:
// 3. Idem punto 2, pero calcular el promedio.
namespace Ejercicio_03Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            int suma = 0;
            int contador = 0;
            float resultadoProm;
            //promedio = suma/contador;
            vector[0] = 3;
            vector[1] = 7;
            vector[2] = 1;
            vector[3] = 5;
            vector[4] = 2;

            int[] vectorDeNumeros = new int[5];
            float promedio;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
                suma += vector[i];//acumulador
                contador++;
            }
            
            Console.WriteLine($"El valor de la suma es: {suma}");
            resultadoProm = (float)suma / contador;

            Console.WriteLine($"El valor del promedio es: {resultadoProm}");
           

            Console.WriteLine("Con Funciones:******************************************");

            CargarVector(vectorDeNumeros);
            Console.WriteLine("***************************");
            MostrarValores(vectorDeNumeros);
            Console.WriteLine($"La suma de los elementos es {SumarValores(vectorDeNumeros)}");
          
            promedio = (float)SumarValores(vectorDeNumeros)/contador;
            
            Console.WriteLine($"El valor del promedio es: {promedio}");
           
            Console.WriteLine("*********Mostrar de mayor a menor******************");
            OrdenVectorMayorMenor(vectorDeNumeros);
            MostrarValores(vectorDeNumeros);
            
            Console.WriteLine("*********Mostrar de menor a mayor******************");
            OrdenVectorMenorMayor(vectorDeNumeros);
            MostrarValores(vectorDeNumeros);
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
        public static int SumarValores(int[] vector)
        {
            int suma = 0;
            foreach (int elemento in vector)
            {
                suma += elemento;
            }
            return suma;
        }
        public static void MostrarValores(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);

            }

        }
        public static void OrdenVectorMayorMenor(int[] vector) 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i+1 ; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j]) 
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;    
                    }
                }
            }
        }
        public static void OrdenVectorMenorMayor(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i+1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
        }

    }
}

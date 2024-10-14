//EJERCICIO 7:
//Crear 3 vectores. En los primeros dos pedirle al usuario que cargue valores. El
// tercer vector deberá guardar el valor más grande como resultado de la
// comparación de los otros dos
//Vector a Vectorb Vectorc
// 5, 4,2,9,3

// 9,3,10,9,1
//9,4,10,9,3
using System.Runtime.Intrinsics;

namespace Ejercicio_07Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector_a = new int[5];
            int[] vector_b = new int[5];
            int[] vector_c = { 9, 4, 10, 9, 3 };
            Console.WriteLine("*******Vector a*********");
            PedirVector(vector_a);
            Console.WriteLine("************************");
            MostrarVector(vector_a);
            Console.WriteLine("*******Vector b*********");
            PedirVector(vector_b);
            Console.WriteLine("************************");
            MostrarVector(vector_b);


        }
        static void PedirVector(int[] vector) 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero {i} de {i+1}: ");
                int numeroIng = int.Parse(Console.ReadLine());
                vector[i] = numeroIng;
            }
        }
        static void MostrarVector(int[] vector  ) 
        {
            foreach (int numero in vector)
            {
                Console.WriteLine(numero);

            }
        }
        static void CompararVector(int[] vetor1, int[] vector2) 
        {
              
        }
    }
}

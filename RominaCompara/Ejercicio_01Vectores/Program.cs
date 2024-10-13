//EJERCICIO 1:
//Cargar un vector de enteros de 5 elementos y mostrarlo.
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
        }
    }
}

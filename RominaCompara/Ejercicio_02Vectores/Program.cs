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
        }
    }
}

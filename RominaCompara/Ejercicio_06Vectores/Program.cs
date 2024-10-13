//EJERCICIO 6:
// Ingresar números en un vector, pueden ser positivos o negativos.
// Mostrar los negativos de forma creciente y los positivos de forma decreciente.
// Ejemplo:
// Vector ingresado: { 5, 1,-9,-1, 9, 3,-2, 2}
//Vector ordenado: { -9,-2,-1, 9, 5, 3, 2, 1}
namespace Ejercicio_06Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 5, 1, -9, -1, 9, 3, -2, 2 };

            int auxiliar;


            // Mostrar los negativos de forma creciente y los positivos de forma decreciente.
            //acemdemte:
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
            //decreciente:
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

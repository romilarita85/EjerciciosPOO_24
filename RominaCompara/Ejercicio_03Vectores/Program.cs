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

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
                suma += vector[i];//acumulador
                contador++;
            }
            
            Console.WriteLine($"El valor de la suma es: {suma}");
            resultadoProm = (float)suma / contador;

            Console.WriteLine($"El valor del promedio es: {resultadoProm}");
        }
    }
}

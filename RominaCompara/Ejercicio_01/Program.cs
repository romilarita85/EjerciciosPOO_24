//Ingresar 2 números y mostrar la suma por consola.
namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numUno;
            int numDos;
            int resultado;

            

            Console.WriteLine("Por favor, ingrese un numero");
            numUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            numDos = int.Parse(Console.ReadLine());
            
            resultado = numUno + numDos;
            
            Console.WriteLine($"La suma de los numeros es:{resultado}");
        }
    }
}

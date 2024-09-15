//Ingresar 2 números y mostrar la suma por consola.
namespace Ejercicio_01Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            int resultado;

            numeroUno = PedirNumInt("Ingrese un numero: ");
            numeroDos = PedirNumInt("Ingrese otro numero: ");
            resultado = SumarNum(numeroUno,numeroDos);

            Console.WriteLine($"La suma de {numeroUno} y {numeroDos} es : {resultado}");
        }
        public static int PedirNumInt(string mensaje) 
        {
            int resultado;
            Console.Write(mensaje);
            resultado = int.Parse(Console.ReadLine());
            return resultado;
        }
        
        public static int SumarNum(int numero1, int numero2) 
        {
            int resultado;//creo una variable del mismo tipo (int)
            resultado = numero1 + numero2;
            return resultado;
        }
    }
}

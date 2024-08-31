//Ingresar nombre, apellido y edad y mostrarlos por pantalla.
namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int edad;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Su nombre y apellido es {nombre} {apellido} y su edad es {edad} ");
        }
    }
}

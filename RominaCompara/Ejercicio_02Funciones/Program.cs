//Ingresar nombre, apellido y edad y mostrarlos por pantalla.
namespace Ejercicio_02Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int edad;

            nombre = PedirDatos("Ingrese su nombre: ");
            apellido = PedirDatos("Ingrese su apellido: ");
            edad = PedirNumInt("ingrese su edad: ");

            Console.WriteLine($"Su nombre y apellido es: {nombre} {apellido} y su edad es: {edad} años");
        }
        /// <summary>
        /// Recibe string y va a retorna su lectura
        /// </summary>
        /// <param name="mensaje">mensaje de tipo string</param>
        /// <returns>
        /// retorna lectura
        /// </returns>
        public static string PedirDatos(string mensaje) 
        {
            string lectura;
            Console.Write(mensaje);//escribe msj
            lectura = Console.ReadLine();//lee mensaje
            return lectura;//retorna
            
        }
        /// <summary>
        /// Recibe un dato string y retorna un tipo de dato int
        /// </summary>
        /// <param name="mensaje">mensaje de tipo string</param>
        /// <returns>
        /// retorna resultado de tipo int
        /// </returns>
        public static int PedirNumInt(string mensaje)
        {
            int resultado;
            Console.Write(mensaje);
            resultado = int.Parse(Console.ReadLine());
            return resultado;
        }
    }
}

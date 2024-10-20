namespace Examen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            char[] arrayCaracteres = new char[5];

            string seguir = "si";


            while (seguir.ToLower() == "si")
            {
                //1-Cargar un array de caracteres en minuscula.Normalizar el ingreso de caracteres con metodo to string

                Console.WriteLine("**********************Menú de opciones*************************");
                Console.WriteLine("1.Cargar un array de caracteres en minusculas. ");
                Console.WriteLine("2.Contar vocales dentro del vector (cuantas a,e,i,o,u)");
                Console.WriteLine("3.Ordenar el array de manera alfabetica y mostrarlo");
                Console.WriteLine("4.Reemplazar la vocal ingresada por teclado por el caracter $");
                Console.WriteLine("5. Mostrar el array de reversa");
                Console.WriteLine("6.Salir");
                Console.Write("Selecciona una opción para  continuar: ");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Vectores.IngresarArray(arrayCaracteres);
                        Vectores.MostrarArrayChar(arrayCaracteres);

                        break;
                    case 2:
                        Vectores.ContarVocales(arrayCaracteres);

                        break;
                    case 3:
                        //ordenar array de manera alfavetica y mostrarlo

                        Vectores.OrdenarArray(arrayCaracteres);
                        Vectores.MostrarArrayChar(arrayCaracteres);

                        break;
                    case 4:
                        //Reemplazar la vocal ingresada por teclado(validar que sea una vocal), por el caracter $.Mostrar el array
                        Vectores.ReemplazarVocal(arrayCaracteres);

                        break;
                    case 5:
                        //Mostrar el array de reversa;

                        Vectores.MostrarArrayReversa(arrayCaracteres);

                        break;
                    case 6:
                        Console.WriteLine("Saliendo. del sistema..");
                        return;
                    //salir

                    default:
                        Console.WriteLine("La opcion ingresada es invalida. Vuelva a intentarlo....");
                        break;
                }

            }
        }
    }
}

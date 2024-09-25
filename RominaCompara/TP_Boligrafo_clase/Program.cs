//En el Main de la clase Program, crear un bolígrafo de tinta “Azul” y un grosor “Fino” y otro de tinta “Roja” y un grosor “Grueso”

//Utilizar todos los métodos y mostrar los resultados por consola.
using Biblioteca_Boligrafo;
using System.Drawing;
namespace TP_Boligrafo_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafo1 = new Boligrafo("Fino",Color.Blue);
            Boligrafo boligrafo2 = new Boligrafo("Grueso", Color.Red);

            Console.WriteLine(boligrafo1.MostrarInformacion());
            Console.WriteLine(boligrafo2.MostrarInformacion());

            boligrafo1.SetColor(Color.Aqua);
            Console.WriteLine(boligrafo1.MostrarInformacion());


            boligrafo1.Escribir("casa");

            string texto = "hola";
            Console.WriteLine(texto.Length);
        }
    }
}

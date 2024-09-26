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
            Boligrafo boligrafo1 = new Boligrafo("Fino", Color.Blue);
            Boligrafo boligrafo2 = new Boligrafo("Grueso", Color.Red);

            Console.WriteLine(boligrafo1.MostrarInformacion());
            Console.WriteLine(boligrafo2.MostrarInformacion());

            boligrafo1.SetColor(Color.Aqua);
            boligrafo1.SetCapTintaMax(20);
            boligrafo1.SetGrosorPunta("Grueso");
            boligrafo1.SetCantidadTinta(55);
            Console.WriteLine(boligrafo1.MostrarInformacion());

            boligrafo2.GetCantidadTinta();
            boligrafo2.GetColor();
            boligrafo2.GetCapTintaMax();
            boligrafo2.GetGrosorPunta();


            string texto =  boligrafo1.Escribir("Hola");
            Console.WriteLine(texto);

            string texto1 = boligrafo2.Escribir("Hola soy Romina");
            Console.WriteLine(texto1);
            //int cantidad = boligrafo1.Recargar(100);
            //Console.WriteLine(cantidad);

        }
    }
}

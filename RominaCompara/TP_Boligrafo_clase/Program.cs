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
            
            //Usanso metodos Set:
            boligrafo1.SetColor(Color.Aqua);
            boligrafo1.SetCapTintaMax(20);
            boligrafo1.SetGrosorPunta("Grueso");
            boligrafo1.SetCantidadTinta(55);
            Console.WriteLine($"Los nuevos valores para mi boligrafo 1 son : {boligrafo1.MostrarInformacion()}");
           
            //Usando metodo Get:
            Console.WriteLine("Consultando valores del boligrafo 2: ");
            Console.Write($"\nColor: {boligrafo2.GetColor()}");
            Console.Write($"\nCantidad de tinta: {boligrafo2.GetCantidadTinta()}");
            Console.Write($"\nCantidad de tinta maxima: {boligrafo2.GetCapTintaMax()}");
            Console.Write($"\nGrosor de punta: {boligrafo2.GetGrosorPunta()}\n");

            //Probando metodo Escribir:
            string texto = boligrafo1.Escribir("Hola");
            Console.WriteLine(texto);

            string texto1 = boligrafo2.Escribir("Hola soy Romina");
            Console.WriteLine(texto1);

            Console.WriteLine($"Estado del boligrafo 1: "); 
            Console.WriteLine(boligrafo1.Escribir("El ejercicio pide: Utilizar todos los métodos y mostrar los resultados por consola"));
           
            Console.WriteLine($"Estado del boligrafo 2: "); 
            Console.WriteLine(boligrafo2.Escribir("Estoy escribiendo un texto para hacer testeo del metodo Recargar. Debo verificar que funcione"));


            //Probando metodo Recargar:
            Console.WriteLine(boligrafo1.Recargar(20)); 

            Console.WriteLine(boligrafo2.Recargar(60));

        }

    }
}

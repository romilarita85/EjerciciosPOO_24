using BibliotecaDeLinternas;
using System.Drawing;

namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linterna l1 = new Linterna("Philips",Color.AntiqueWhite);
            Linterna l2 = new Linterna("Everedy",180,false,Color.Aqua);
            
            Console.WriteLine();
            Console.WriteLine(l2.MostrarInfo());
            
            Console.WriteLine("Usando metodo utilizar linterna*****");
            if (l2.UtilizarLinterna(181))
            {
                Console.WriteLine("Se pudo utilizar");
            }
            else 
            {
                Console.WriteLine("No se pudo utilizar");
            }
            Console.WriteLine(l2.MostrarInfo());//para ver con cuanto quedo de bateria
        }
    }
}

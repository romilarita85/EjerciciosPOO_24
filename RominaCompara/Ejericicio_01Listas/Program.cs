//En el main, crear 5 personas y agregarlas a una lista. 
//En la clase persona crear un método estático que reciba una lista de personas,
//y permita mostrar cada una de las instancias de la lista.
using BibliotecaPersonas;
namespace Ejericicio_01Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("34567890", "Carlos", 36, "Colombia");
            Persona persona2 = new Persona("32116989", "Veronica", 30, "Venezuela");
            Persona persona3 = new Persona("41961821", "jose", 25, "Uruguay");
            Persona persona4 = new Persona("44517267", "Rosa", 28, "Paraguay");
            Persona persona5 = new Persona("31536896", "Diego", 31, "Argentina");

            List<Persona>personas = new List<Persona>();

            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);
            personas.Add(persona4);
            personas.Add(persona5);

            Persona.MostrarLista(personas);

        }
    }
}

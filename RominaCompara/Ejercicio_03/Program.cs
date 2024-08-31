//En un hospital existen 3 áreas: Cardiología, Pediatría y Traumatología. El
//presupuesto anual del hospital se reparte conforme a la siguiente tabla:
//Área Porcentaje del presupuesto
//Cardiología 40%
//Pediatría 45%
//Traumatología 15%
//A partir del ingreso del presupuesto anual, calcular el dinero que se destinará a cada
//área.
namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ptoCardio;
            double ptoPedia;
            double ptoTrauma;
            double ptoAnual;
            double valorPjeC = 0.4;
            double valorPjeP = 0.45;
            double valorPjeT = 0.15;
        

            Console.WriteLine("Ingrese su presupuesto Anual");
            ptoAnual = double.Parse(Console.ReadLine());

            ptoCardio = ptoAnual * valorPjeC;
            ptoPedia = ptoAnual * valorPjeP;
            ptoTrauma = ptoAnual * valorPjeT;



            Console.WriteLine("El dinero que se destinará a cada área sera de:"); 
            Console.WriteLine($"Para cardiologia ${ptoCardio}");
            Console.WriteLine($"Para pediatria ${ptoPedia}");
            Console.WriteLine($"Para traumatologia ${ptoTrauma}");
        }
    }
}

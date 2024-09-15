//En un hospital existen 3 áreas: Cardiología, Pediatría y Traumatología. El
//presupuesto anual del hospital se reparte conforme a la siguiente tabla:
//Área Porcentaje del presupuesto
//Cardiología 40%
//Pediatría 45%
//Traumatología 15%
//A partir del ingreso del presupuesto anual, calcular el dinero que se destinará a cada
//área.
namespace Ejercicio_03Funciones
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

            ptoAnual = PedirDouble("Ingrese su presupuesto Anual: ");

            ptoCardio = ValorPto(ptoAnual,valorPjeC);
            ptoPedia = ValorPto(ptoAnual,valorPjeP);
            ptoTrauma = ValorPto(ptoAnual,valorPjeT);

            Console.WriteLine("El dinero que se destinará a cada área sera de:");
            Console.WriteLine($"Para cardiologia ${ptoCardio}");
            Console.WriteLine($"Para pediatria ${ptoPedia}");
            Console.WriteLine($"Para traumatologia ${ptoTrauma}");
        }
        public static double PedirDouble(string mensaje)
        {
            double resultado;
            Console.Write(mensaje);
            resultado = double.Parse(Console.ReadLine());
            return resultado;
        }
        public static double ValorPto(double monto, double porcentaje) 
        {
            double resultado;
            return resultado = monto * porcentaje;
        }
    }
}

namespace Ejercicio_08_Perimetros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------Perimetro Rectangulo--------------------
            double baseRectangulo;
            double alturaRectangulo;
            double resultado;

            Console.WriteLine("Ingrese la base de un rectangulo");
            baseRectangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura de un rectangulo");
            alturaRectangulo = double.Parse(Console.ReadLine());

            resultado = CalcularPerimetroRectangulo(baseRectangulo, alturaRectangulo);

            Console.WriteLine($"El perimetro del rectangulo es:{resultado}");
            //--------------Circulo----------------------------------
            double resultadoCirc;
            double piCirculo;
            double radioCirculo;

            Console.WriteLine("Ingrese pi del circulo");
            piCirculo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el radio");
            radioCirculo = double.Parse(Console.ReadLine());

            resultadoCirc = CalcularPerimetroCirculo(piCirculo, radioCirculo);
            Console.WriteLine($"El perimetro de un circulo es: {resultadoCirc}");
            //------------------
            double resultadoTri;
            double lado;
            double baseTriangulo;

            Console.WriteLine("Ingrese valor del lado");
            lado = double.Parse(Console.ReadLine());
            
            
            resultadoTri = CalcularPerimetroTrianguloEquilatero(lado);
            Console.WriteLine($"El perimetro del triangulo es: {resultadoTri}");

           
        }
        static double CalcularPerimetroRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            double perimetro;

            perimetro = 2 * (baseRectangulo + alturaRectangulo);

            return perimetro;

        }
        static double CalcularPerimetroCirculo(double piCirculo, double radioCirculo)
        {
            double perimetro;

            perimetro = 2 * piCirculo * radioCirculo;

            return perimetro;
        }
        static double CalcularPerimetroTrianguloEquilatero(double lado)
        {
            double perimetro;
            perimetro = lado * 3;

            return perimetro;
        }

    }
}

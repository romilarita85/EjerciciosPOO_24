using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_08_PerimetrosAreas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string funcion = string.Empty;
            string eleccion = string.Empty;
            double baseFuncion = double.NaN;
            double alturaFuncion = double.NaN;
            double resultado = 0;
            double piCirculo = 3.14;
            double radioCirculo = double.NaN;
            double lado = double.NaN;
      
           
            Console.WriteLine("Ingrese una funcion geometrica");
            funcion = Console.ReadLine();

            if (string.IsNullOrEmpty(funcion))
            {
                Console.WriteLine("Error!!Debe ingresar una funcion para realizar los calculos:");

            }
            Console.WriteLine("Decea calcular: area/perimetro");
            eleccion = Console.ReadLine();

            switch (funcion)
            {
                case "circulo":
                    if (eleccion.ToLower() == "area")
                    {
                        radioCirculo = PedirValores("Ingrese radio del circulo: ");

                        resultado = CalcularAreaCirculo(piCirculo, radioCirculo);
                        Console.WriteLine($"El area del circulo es {resultado}");
                    }
                    else
                    {
                        radioCirculo = PedirValores("Ingrese el radio del circulo");

                        resultado = CalcularPerimetroCirculo(piCirculo, radioCirculo);
                        Console.WriteLine($"El perimetro de un circulo es: {resultado}");
                    }

                    break;

                case "triangulo":
                    if (eleccion.ToLower() == "area")
                    {

                        baseFuncion = PedirValores("Ingrese la base del triangulo");
                        alturaFuncion = PedirValores("Ingrese la altura del triangulo");

                        resultado = CalcularAreaTriangulo(baseFuncion, alturaFuncion);
                        Console.WriteLine($"El area del triangulo es {resultado}");
                    }
                    else
                    {
                        lado = PedirValores("Ingrese valor del lado");
                        resultado = CalcularPerimetroTrianguloEquilatero(lado);
                        Console.WriteLine($"El perimetro del triangulo es: {resultado}");
                    }

                    break;

                case "rectangulo":
                    if (eleccion.ToLower() == "area")
                    {
                        baseFuncion = PedirValores("Ingrese la base del rectangulo");
                        alturaFuncion = PedirValores("Ingrese la altura del rectangulo"); ;

                        resultado = CalcularAreaRectangulo(baseFuncion, alturaFuncion);
                        Console.WriteLine($"El area del rectangulo es {resultado}");
                    }
                    else
                    {
                        baseFuncion = PedirValores("Ingrese la base de un rectangulo");
                        alturaFuncion = PedirValores("Ingrese la altura de un rectangulo");

                        resultado = CalcularPerimetroRectangulo(baseFuncion, alturaFuncion);

                        Console.WriteLine($"El perimetro del rectangulo es: {resultado}");

                    }

                    break;
                default:
                    //opcion incorrecta
                    Console.WriteLine("La opcion ingresada no es valida");
                    break;
            }
          
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
        static double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            double area;

            area = baseRectangulo * alturaRectangulo;

            return area;
        }
        static double CalcularAreaCirculo(double piCirculo, double radioCirculo)
        {
            double areaDeCirculo;

            areaDeCirculo = piCirculo * (radioCirculo * radioCirculo);
            return areaDeCirculo;
        }
        static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double area;

            area = (baseTriangulo * alturaTriangulo) / 2;

            return area;
        }
        static double PedirValores(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }
    }
}

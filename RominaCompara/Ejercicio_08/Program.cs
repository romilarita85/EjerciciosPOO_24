//8-Funciones Geométricas. Crear funciones que calculen:
//Área de: triangulo, circulo y rectangulo.
//Perímetro del: triangulo(equilatero), circulo y rectangulo
namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {//----------------------AREAS-------------------------------
            //-------------------RECTANGULO-------------------------
            //double resultado;
            //resultado = CalcularAreaRectangulo(10,7);
            //Console.WriteLine(resultado);   
            double resultadoRec;
            double baseRectangulo;
            double alturaRectangulo;

            Console.WriteLine("Ingrese la base del rectangulo");
            baseRectangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo");
            alturaRectangulo = double.Parse(Console.ReadLine());
            //Console.WriteLine(CalcularAreaRectangulo);
            resultadoRec = CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);
            Console.WriteLine(resultadoRec);
            

            //-----------------------CIRCULO------------------------
            double resultadoCir;
            double piCirculo;
            double radioCirculo;

            Console.WriteLine("Ingrese pi");
            piCirculo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese radio del circulo");
            radioCirculo = double.Parse(Console.ReadLine());

            resultadoCir = CalcularAreaCirculo(piCirculo, radioCirculo);
            Console.WriteLine(resultadoCir);
            //-------------------TRIANGULO---------------------------
            double resultadoTri;
            double baseTriangulo;
            double alturaTriangulo;

            Console.WriteLine("Ingrese la base del rectangulo");
            baseTriangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo");
            alturaTriangulo = double.Parse(Console.ReadLine());

            resultadoTri = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
            Console.WriteLine(resultadoTri);
     

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
       


    }
}

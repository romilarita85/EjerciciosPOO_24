//9-Menú de usuario: Crear un menú de usuario para las funciones geométricas (ej 8).
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ingresar una figura geometrica
            //Decea calcular area o perimetro
            //Realizar calculo
            //mostrar resultado
            string funcion = string.Empty;
            double area;
            string eleccion = string.Empty;
            double perimetro;
            string seguir = "si";
            int opcion;
            double resultadoRec;
            double baseRectangulo;
            double alturaRectangulo;
           
            double resultadoCir;
            double piCirculo;
            double radioCirculo;
            
            double resultadoTri;
            double baseTriangulo;
            double alturaTriangulo;
            double ladoTri;

            while (seguir.ToLower() == "si") 
            {
                opcion = RetornaOpcionDelMenuFunciones();

                switch (opcion)
                {   
                    
                    case 1:
                        Console.WriteLine("Ingrese una funcion geometrica");
                        funcion = Console.ReadLine();
                      
                        if (string.IsNullOrEmpty(funcion)) 
                        {
                            Console.WriteLine("Error!!Debe ingresar una funcion para realizar los calculos:");
                
                        }
                     
                        break;

                    case 2:
                        Console.WriteLine("Decea calcular: a-Area/p-perimetro");
                        eleccion = Console.ReadLine();
                        break;

                    case 3:
                        
                        //Realizar calculo y mostrarlo
                        if (eleccion.ToLower() == "area") 
                        {
                            switch (funcion)
                            {
                                case "rectangulo":
                                    Console.WriteLine("Ingrese la base del rectangulo");
                                    baseRectangulo = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la altura del rectangulo");
                                    alturaRectangulo = double.Parse(Console.ReadLine());
                                    //Console.WriteLine(CalcularAreaRectangulo);
                                    resultadoRec = CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);
                                    Console.WriteLine($"El area del rectangulo es {resultadoRec}");
                                    break;

                                case "circulo":
                                    Console.WriteLine("Ingrese pi");
                                    piCirculo = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese radio del circulo");
                                    radioCirculo = double.Parse(Console.ReadLine());

                                    resultadoCir = CalcularAreaCirculo(piCirculo, radioCirculo);
                                    Console.WriteLine($"El area del circulor es {resultadoCir}");

                                    break;
                                case "triangulo":
                                    Console.WriteLine("Ingrese la base del triangulo");
                                    baseTriangulo = double.Parse(Console.ReadLine());

                                    Console.WriteLine("Ingrese la altura del triangulo");
                                    alturaTriangulo = double.Parse(Console.ReadLine());

                                    resultadoTri = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                                    Console.WriteLine($"El area del triangulo es {resultadoTri}");

                                    break;
                            }
                        }
                        else
                        {
                            if (eleccion.ToLower() == "perimetro") 
                            {
                                switch (funcion)//perimetros
                                {
                                    case "rectangulo":
                                        Console.WriteLine("Ingrese la base de un rectangulo");
                                        baseRectangulo = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Ingrese la altura de un rectangulo");
                                        alturaRectangulo = double.Parse(Console.ReadLine());

                                        resultadoRec = CalcularPerimetroRectangulo(baseRectangulo, alturaRectangulo);

                                        Console.WriteLine($"El perimetro del rectangulo es: {resultadoRec}");

                                        break;

                                    case "circulo":
                                        Console.WriteLine("Ingrese pi del circulo");
                                        piCirculo = double.Parse(Console.ReadLine());

                                        Console.WriteLine("Ingrese el radio");
                                        radioCirculo = double.Parse(Console.ReadLine());

                                        resultadoCir = CalcularPerimetroCirculo(piCirculo, radioCirculo);
                                        Console.WriteLine($"El perimetro de un circulo es: {resultadoCir}");

                                        break;

                                    case "triangulo":
                                        Console.WriteLine("Ingrese valor del lado");
                                        ladoTri = double.Parse(Console.ReadLine());
                                        resultadoTri = CalcularPerimetroTrianguloEquilatero(ladoTri);
                                        Console.WriteLine($"El perimetro del triangulo es: {resultadoTri}");

                                        break;
                                }
                            }

                        }
                       break;
                    default:
                        //salir del programa
                        Console.WriteLine("Saliendo del sistema");
                        seguir = "no";
                       break;
                }
            }
             
        }
        static void MostrarMenuFunciones() //funcion para mostrar
        {
            Console.WriteLine("\t\t\a ****Bienvenido/a al menu de funciones geometricas ****");
            
            Console.WriteLine("1.Para ingresar la figura geometrica: ");
            Console.WriteLine("2.Que decea calcular: ");
            Console.WriteLine("3.Realizar calculo y mostrar resultado: ");
            Console.WriteLine("4.Salir del programa");

            Console.Write("Por favor.Ingrese una opcion para continuar: ");

        }
        static int RetornaOpcionDelMenuFunciones() //retorna las opciones
        {
            int resultado;
            MostrarMenuFunciones();
            resultado = int.Parse(Console.ReadLine());

            return resultado;
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

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
            double area = double.NaN;
            string eleccion = string.Empty;
            double perimetro = double.NaN;
            string seguir = "si";
            int opcion;
            double resultado = 0;
            double baseFuncion = 0;
            double alturaFuncion = 0;
            double piCirculo = 3.14;
            double radioCirculo = double.NaN;
           
            double ladoTri = double.NaN;

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
                        Console.WriteLine("Decea calcular: area/perimetro");
                        eleccion = Console.ReadLine();
                        break;
                    case 3://realizar calculo y mostrar resultado

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
                                    ladoTri = PedirValores("Ingrese valor del lado");
                                    resultado = CalcularPerimetroTrianguloEquilatero(ladoTri);
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
                       
                        Console.WriteLine("Precione una tecla para continuar.......");
                        Console.ReadKey();//precione una tecla cualquiera
                        Console.Clear();//limpia
                        break;

                }
                
            }
             
        }
        static void MostrarMenuFunciones() //funcion para mostrar
        {
            Console.WriteLine("\t\t\t ****Bienvenido/a al menu de funciones geometricas ****");
            
            Console.WriteLine("1.Para ingresar la figura geometrica: ");
            Console.WriteLine("2.Que decea calcular: ");
            Console.WriteLine("3.Realizar calculo y mostrar resultado: ");
            //Console.WriteLine("4.Mostrar resultado);
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
        static double PedirValores(string mensaje) 
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }
        
    }
}
//case 4://agregar case para mostrar resultados

//    if (eleccion.ToLower() == "area")
//    {
//        switch (funcion)
//        {
//            case "rectangulo":
//                resultado = CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);
//                Console.WriteLine($"El area del rectangulo es {resultadoRec}");
//                break;

//            case "circulo":

//                resultadoCir = CalcularAreaCirculo(piCirculo, radioCirculo);
//                Console.WriteLine($"El area del circulor es {resultadoCir}");

//                break;
//            case "triangulo":

//                resultadoTri = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
//                Console.WriteLine($"El area del triangulo es {resultadoTri}");

//                break;
//        }
//    }
//    else
//    {
//        if (eleccion.ToLower() == "perimetro")
//        {
//            switch (funcion)//perimetros
//            {
//                case "rectangulo":

//                    resultadoRec = CalcularPerimetroRectangulo(baseRectangulo, alturaRectangulo);

//                    Console.WriteLine($"El perimetro del rectangulo es: {resultadoRec}");

//                    break;

//                case "circulo":

//                    resultadoCir = CalcularPerimetroCirculo(piCirculo, radioCirculo);
//                    Console.WriteLine($"El perimetro de un circulo es: {resultadoCir}");

//                    break;

//                case "triangulo":

//                    resultadoTri = CalcularPerimetroTrianguloEquilatero(ladoTri);
//                    Console.WriteLine($"El perimetro del triangulo es: {resultadoTri}");

//                    break;
//            }

//        }

//        break;
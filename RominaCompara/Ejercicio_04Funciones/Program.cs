//A partir del ingreso del nombre de un alumno y su nota, mostrar el nombre del
//alumno y su condición frente al examen:
//○ Si la nota está entre 1 y 3: el alumno está desaprobado.
//○ Si la nota está entre 4 y 5: el alumno está regularizado.
//○ Si la nota está entre 6 y 10: el alumno está promocionado
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_04Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int nota;
            string condicionAlumno;

            while (true) 
            {
                nombre = PedirDato("Ingrese su nombre: ");
                nota = PedirNota("Ingrese su nota: ");
                condicionAlumno = EvaluarNota(nota);

                Console.WriteLine($"Su nombre es: {nombre}, su nota es {nota} y su condicion frente al examen es: {condicionAlumno}");

                Console.ReadKey();//hace una pausa
            }
        }
        public static string PedirDato(string mensaje)
        {
            string lectura;
            Console.Write(mensaje);
            return lectura = Console.ReadLine();
        }
        public static int PedirNota(string mensaje)
        {
            int resultado;
            Console.Write(mensaje);
            resultado = int.Parse(Console.ReadLine());
            return resultado;
        }

        //○ Si la nota está entre 1 y 3: el alumno está desaprobado.
        //○ Si la nota está entre 4 y 5: el alumno está regularizado.
        //○ Si la nota está entre 6 y 10: el alumno está promocionado
        public static string EvaluarNota(int nota)
        {
            string condicion = string.Empty;
            if (nota > 0 && nota < 11)
            {
                if (nota > 5) //○ Si la nota está entre 6 y 10: el alumno está promocionado
                {
                    condicion = "Promocionado";
                }
                else
                {
                    if (nota > 3)
                    {
                        condicion = "Regularizado";  //○ Si la nota está entre 4 y 5: el alumno está regularizado.
                    }
                    else
                    {
                        condicion = "Desaprobado";//○ Si la nota está entre 1 y 3: el alumno está desaprobado.
                    }
                }
            }

            return condicion;
        }
        public static string EvaluarNota2(int nota)
        {
            string condicion = string.Empty;
          
                if (nota >= 1 && nota <= 10)
                {
                    if (nota >= 6 && nota <= 10)
                    {
                        condicion = "Promocionado";
                    }
                    else
                    {
                        if (nota >= 4 && nota < 6)
                        {
                            condicion = "Regularizado";
                        }
                        else
                        {
                            if (nota >= 1 && nota < 4)
                            {
                                condicion = "Desaprobado";
                            }
                        }

                    }
                }
              
            return condicion;
        }
    }
}

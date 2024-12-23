﻿//EJERCICIO 5:
// Ingresar datos en un vector y mostrarlos al revés.
namespace Ejercicio_05Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5];
            Console.WriteLine("*********Cargar datos al vector**********");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero: {i}  de {i + 1}");
                int numIng = int.Parse(Console.ReadLine());
                vector[i] = numIng;
        
            }

            Console.WriteLine("**********Mostrar vector al reves*********");
            for (int i = vector.Length - 1 ; i >= 0 ; i--)
            {
                Console.WriteLine(vector[i]);
            }

            Console.WriteLine("**************Con Funciones****************");
         
            int[] vectorDeNumeros = new int[5];

            Console.WriteLine("*********Cargar datos al vector**********");
            CargarDatos(vectorDeNumeros);
            
            Console.WriteLine("********Mostrar vector ingresado***********");
            MostrarVector(vectorDeNumeros);
            
            Console.WriteLine("**********Mostrar vector al reves*********");
            MostrarVectorAlRev(vectorDeNumeros);
        }
        static void CargarDatos(int[] vector) 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero: {i}  de {i + 1}");
                int numIng = int.Parse(Console.ReadLine());
                vector[i] = numIng;
            }
        }
        static void MostrarVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
        static void MostrarVectorAlRev(int[] vector) 
        {
            for (int i = vector.Length -1 ; i >= 0; i--)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}

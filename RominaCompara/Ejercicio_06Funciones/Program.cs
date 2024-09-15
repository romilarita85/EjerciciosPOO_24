//Ejercicio_06:
//Ingresar 15 números y determinar:
//○ Sumadelosnegativos.
//○ Sumadelospositivos.
//○ Cantidad de positivos.
//○ Cantidad de negativos.
//○ Cantidad de ceros.
//○ Cantidad de números pares.
//○ Promedio de positivos.
//○ Promedio de negativos.
//○ Diferencia entre positivos y negativos, (positivos - negativos).
//○ El número máximo
//○ De los negativos el mínimo
using System;

namespace Ejercicio_06Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sumaNegativos = 0;
            int sumaPositivos = 0;
            int numIng = 0;
            int cantidadPositivos = 0;
            int cantidadNegativos = 0;
            int cantidadCeros = 0;
            int cantidadNumPares = 0;
            int promedioPositivos = 0;
            int promedioNegativos = 0;
            int difPosNeg;
            int numMax = 0;
            int numMinNeg = 0;
            bool primerNeg = false;
        

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese un numero {i} de 15 ");
                num = int.Parse(Console.ReadLine());
               
                 switch (EvaluarPositividad(num))
                 {
                     case 0:
                         cantidadCeros = EvaluarCantidadCeros(cantidadCeros);//0k
                         break;
                     case 1:
                        sumaPositivos = SumarPositivos(num,sumaPositivos);//ok
                        cantidadPositivos = EvaluarCantidadPositivos(cantidadPositivos);//ok
                         break;
                     default:
                        sumaNegativos = SumarNegativos(num, sumaNegativos); //ok
                        cantidadNegativos = EvaluarCantidadNegativos(cantidadNegativos);//ok
                       
                        break;
                 }
                if (num % 2 == 0)  //○ Cantidad de números pares.
                {
                    cantidadNumPares = cantidadNumPares + 1;
                }
                if (i == 1 || numIng > numMax) //○ El número máximo
                {//i = variable d control-indica primer numero ingesado
                    numMax = numIng;
                }
                if ((numIng < 0 && primerNeg == false) || (numIng < 0 && numIng < numMinNeg))  //○ De los negativos el mínimo
                {
                    numMinNeg = numIng;
                    primerNeg = true;
                }
              
            }
            if (cantidadPositivos != 0)//○ Promedio de positivos.
            {
                promedioPositivos = sumaPositivos / cantidadPositivos;
            }
            if (cantidadNegativos != 0)//○ Promedio de negativos.
            {
                promedioNegativos = sumaNegativos / cantidadNegativos;
            }

            difPosNeg = sumaPositivos - (-sumaNegativos);//○ Diferencia entre positivos y negativos, (positivos - negativos).
            
            Console.WriteLine($"La suma de los negativos es: {sumaNegativos}");//ok
            Console.WriteLine($"La suma de los positivos es: {sumaPositivos}");//ok
            Console.WriteLine($"La cantidad de los positivos es: {cantidadPositivos}");//ok
            Console.WriteLine($"La cantidad de los negativos es: {cantidadNegativos}");//ok
            Console.WriteLine($"La cantidad de ceros es: {cantidadCeros}");//ok
            Console.WriteLine($"La cantidad de numeros pares es: {cantidadNumPares}");
            Console.WriteLine($"El promedio de los positivos es: {promedioPositivos}");//ok;
            Console.WriteLine($"El promedio de los negativos es: {promedioNegativos}");//ok
            Console.WriteLine($"La diferencia entre positivos y negativos, (positivos - negativos) es: {difPosNeg}"); //ok
            Console.WriteLine($"El numero maximo es: {numMax}");
            Console.WriteLine($"De los negativos el minimo: {numMinNeg}");
        }

        public static bool EsPar(int numero) 
        {
            bool par = false; //no es par
            if (numero % 2 == 0) //para evaluar paridad-si el resto queda en cero quiere decir q se pudo dividir por 2 y es par
            {
                par = true;
            }
            return par;
        }
       

        public static int EvaluarPositividad(int numero) 
        {
            int positividad = 0;
            if (numero > 0)//positivo
            {

                positividad = 1;
            }
            else //sino es negativo
            {
                if (numero < 0)
                {
                    positividad = -1;
                }
            }
            return positividad;
        }
        public static int SumarPositivos(int numIng, int sumaPos) 
        {
            
            if (numIng > 0)//positivo
            {
                sumaPos += numIng;

            }
            return sumaPos;
        }
        public static int SumarNegativos(int numIng, int sumaNeg)
        {

            if (numIng < 0)//positivo
            {
                sumaNeg += numIng;

            }
            return sumaNeg;
        }
        public static int EvaluarCantidadPositivos( int cantidadPositivos) 
        {
            return cantidadPositivos += 1;
        }
        public static int EvaluarCantidadNegativos(int cantidadNegativos) 
        {
            return cantidadNegativos += 1;
        }
        public static int EvaluarCantidadCeros(int cantidadCeros) //ok
        {
            return cantidadCeros = cantidadCeros + 1;
        }
        public static int EvaluarCantidadPares(int numero) //revisar-consultar
        {
            int cantidadPares = 0;
            if (numero % 2 == 0)  //○ Cantidad de números pares.
            {
                cantidadPares = cantidadPares + 1;
            }
            return cantidadPares;
        }
        public static int EvaluarNumMax(int numMax)//revisar-Consultar
        {
            int num = 0;
            int i = 0;
            if (i == 1 || num > numMax) //○ El número máximo
            {//i = variable d control-indica primer numero ingesado
                numMax = num;
            }
            return num;
        }
    }
}

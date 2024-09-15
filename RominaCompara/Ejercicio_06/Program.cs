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
//○ Delosnegativos el mínimo
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Ejercicio_06
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

                if (num > 0)
                {
                    sumaPositivos += numIng;//sumaPositivos = sumaPositivos + numIng;//Sumadelospositivos
                    cantidadPositivos += 1;//cantidadPositivos = cantidadPositivos + 1;//○ Cantidad de positivos.
                }
                else 
                {
                    sumaNegativos -= numIng;//sumaNegativos = sumaNegativos - numIng;//Sumadelosnegativos.
                    cantidadNegativos -= 1;//cantidadNegativos = cantidadNegativos - 1;//Cantidad de negativos.
                }
                
                if (num == 0)//○ Cantidad de ceros.
                {
                    cantidadCeros = cantidadCeros + 1;
                }
                if (num % 2 == 0)  //○ Cantidad de números pares.
                {
                    cantidadNumPares = cantidadNumPares + 1;
                }
               
               

                if (i == 1 || numIng > numMax) //○ El número máximo
                {//i = variable d control-indica primer numero ingesado
                    numMax = numIng;
                }

                //Revisar(ver otra forma)__________________
                if ( (numIng < 0 && primerNeg == false) || (numIng < 0 && numIng < numMinNeg) )  //○ De los negativos el mínimo
                { 
                    numMinNeg = numIng;
                    primerNeg = true;
                }
            //________________________

            }

            if (cantidadPositivos != 0)    //○ Promedio de positivos.
            {
                promedioPositivos = sumaPositivos / cantidadPositivos;
            }
            if (cantidadNegativos != 0) //○ Promedio de negativos.
            {
                promedioNegativos = sumaNegativos / cantidadNegativos;
            }
            difPosNeg = sumaPositivos - (-sumaNegativos);//○ Diferencia entre positivos y negativos, (positivos - negativos).
            
            Console.WriteLine($"La suma de los negativos es: {sumaNegativos}");
            Console.WriteLine($"La suma de los positivos es: {sumaPositivos}");
            Console.WriteLine($"La cantidad de los positivos es: {cantidadPositivos}");
            Console.WriteLine($"La cantidad de los negativos es: {cantidadNegativos}");
            Console.WriteLine($"La cantidad de ceros es: {cantidadCeros}");
            Console.WriteLine($"La cantidad de numeros pares es: {cantidadNumPares}");
            Console.WriteLine($"El promedio de los positivos es: {promedioPositivos}");
            Console.WriteLine($"El promedio de los negativos es: {promedioNegativos}");
            Console.WriteLine($"La diferencia entre positivos y negativos, (positivos - negativos) es: {difPosNeg}");
            Console.WriteLine($"El numero maximo es: {numMax}");
            Console.WriteLine($"De los negativos el minimo: {numMinNeg}");
        
        }
       
    }
}

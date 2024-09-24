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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_06Funciones
{
    //enumerado
    public enum Signo
    {
        Positivo,
        Negativo,
        Cero
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sumaNegativos = 0;
            int sumaPositivos = 0;
      
            int cantidadPositivos = 0;
            int cantidadNegativos = 0;
            int cantidadCeros = 0;
            int cantidadNumPares = 0;
            float promedioPositivos;//No se inicializan los promedio no son contadores ni acumuladores
            float promedioNegativos;
            int difPosNeg;
            int numMax = 0;
            int numMinNeg = 0;
           
        

            for (int i = 0; i < 5; i++)
            {
                num = PedirNumero($"Ingrese un numero {i} de 15 ");
                Signo signo = VerificarSigno(num);
                switch (signo)
                {
                     case Signo.Cero:
                         cantidadCeros ++ ;
                         break;
                     case Signo.Positivo:
                        sumaPositivos += num ;
                        cantidadPositivos++;
                         break;
                     case Signo.Negativo:
                        sumaNegativos += num ; 
                        cantidadNegativos ++;
                        
                        //○ De los negativos el mínimo
                        if (cantidadNegativos == 1 || num < numMinNeg)
                        {// el primer numero q ingreso es el minimo 
                            numMinNeg = num;
                        }
                        break;
                }
                //○ Cantidad de números pares.
                if (VerificarParidad(num) == true) //me interesa q sea true
                { //tengo el universo de los pares
                    cantidadNumPares++;
                }
                //○ El número máximo
                if (i == 1 || num > numMax) 
                {//i = variable d control-indica primer numero ingesado
                    numMax = num;
                }

            }
            Console.WriteLine($"1.La suma de los negativos es: {sumaNegativos}");//ok
            Console.WriteLine($"2.La suma de los positivos es: {sumaPositivos}");//ok
            Console.WriteLine($"3.La cantidad de los positivos es: {cantidadPositivos}");//ok
            Console.WriteLine($"4.La cantidad de los negativos es: {cantidadNegativos}");//ok
            Console.WriteLine($"5.La cantidad de ceros es: {cantidadCeros}");//ok
            Console.WriteLine($"6.La cantidad de numeros pares es: {cantidadNumPares}");
           
            //○ Promedio de positivos.
            if (cantidadPositivos > 0)//si la cantidad de positivos es mayor a cero significa q por lo menos un positivo ingres0
            {
                promedioPositivos = CalcularPromedio(sumaPositivos, cantidadPositivos);
                Console.WriteLine($"7.El promedio de los positivos es: {promedioPositivos}");
            }
            else
            {
                Console.WriteLine("7.No se ingresaron numeros positivos para calcular el promedio.");
            }
            //○ Promedio de negativos.
            if (cantidadNegativos > 0)
            {
                promedioNegativos = CalcularPromedio(sumaNegativos,cantidadNegativos);
                Console.WriteLine($"8.El promedio de los negativos es: {promedioNegativos}");
            }
            else
            {
                Console.WriteLine("8.No se ingresaron numeros negativos para calcular el promedio.");
            }

            
            difPosNeg = sumaPositivos - (-sumaNegativos);//○ Diferencia entre positivos y negativos, (positivos - negativos).
            Console.WriteLine($"9.La diferencia entre positivos y negativos, (positivos - negativos) es: {difPosNeg}"); //ok
            
            
            Console.WriteLine($"10.El numero maximo es: {numMax}");
            
            Console.WriteLine($"11.De los negativos el minimo: {numMinNeg}");


        }
         //Funcion para pedir numero
        static int PedirNumero(string msj) 
        {
            int numero; //numero leido o ingresado
            Console.WriteLine(msj);
            numero = int.Parse(Console.ReadLine());
            return numero;//retorna numero(devuelve)
        }
        static Signo VerificarSigno(int numero) //USANDO ENUMERADOS
        {
            Signo esPositivo = Signo.Cero; // por default el numero es cero
            if (numero > 0)
            {
                esPositivo = Signo.Positivo;
            }
            else
            {
                if (numero < 0)
                {
                    esPositivo = Signo.Negativo;
                }
            }
            return esPositivo;
        }
        public static bool VerificarParidad(int numero) 
        {
            bool esPar = false; //no es par
            if (numero != 0 && numero % 2 == 0) //para evaluar paridad-si el resto queda en cero quiere decir q se pudo dividir por 2 y es par
            {
                esPar = true;
            }
            return esPar;
        }
        static float CalcularPromedio(int suma, int contador)
        {
            float resultado;
            resultado = (float)suma / contador; // castear (a float) para que no haya perdida de informacion
            //un entero sobre un entero por ende se debe convertir en flotante
            return resultado;
        }
        //funcion para calcular diferencia
        static int CalcularDiferencia(int unNumero, int otroNumero)
        {
            int resultado;
            resultado = unNumero - otroNumero;
            return resultado;
        }


    }
}

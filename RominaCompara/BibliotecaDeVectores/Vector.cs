using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace BibliotecaDeVectores
{
    public static class Vector
    {
        //METODOS PARA CARGAR ARRAY
        public static void CargarArray1(char[] vector)
        {
            string lectura;
            Console.Write("Ingrese una palabra: ");

            lectura = Console.ReadLine();
            vector = lectura.ToCharArray();
        }

        public static char[] CargarArray2()// no estoy limitado por la cantidad de letras *USAR*
        {
            string lectura;

            Console.Write("Ingrese una palabra: ");
            lectura = Console.ReadLine();//readline te devuelve un string

            return lectura.ToCharArray();
        }
        static char[] PedirVector() //Pedir datos para un array
        {//si lo va a retornar no hacer falta q lo pida por parametro ya me devuelve un array
            string ingreso;
            char[] vector;

            Console.WriteLine("Ingrese una cadena: ");//pide la cadena
            ingreso = Console.ReadLine();//la guardo en ingreso(variable de tipo string)
            vector = ingreso.ToCharArray();//convierto esa cadena en un array

            return vector; //Si la funcion recibe un parametro ya viene con un dato cargado
            //no tiene q pedir el vector por q ya viene cargado
        }

        public static void CargarArray3(char[] vector)
        {
            string lectura;
            Console.Write("Ingrese una palabra de 5 letras: ");
            lectura = Console.ReadLine();

            while (lectura.Length != 5)
            {
                Console.Write(">>>>La palabra debe ser de 5 letras<<<");
                Console.Write("Ingrese una palabra de 5 letras: ");
                lectura = Console.ReadLine();

            }
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = lectura[i];
            }
        }
        public static void CargarArrayCaracteres(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Ingrese un carácter {i + 1}: ");
                array[i] = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

        }
        static void CargarVector(int[] numeros) 
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
         
        }
        public static void CargarVector1(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero {i + 1} de {vector.Length}");//linea para decirle al usuario q ingrese el numero

                int numeroIngresado = int.Parse(Console.ReadLine());//lee (parseo)
                vector[i] = numeroIngresado; //(Asigna) Para guardar el numero ingresado en cada posicion de i

            }
        }
        static void CargarVector2(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese un numero {i} de {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                vector[i] = numero;
            }
        }

        //METODO PARA MOSTRAR ARRAY
        public static void MostrarArrayChar(char[] vector)
        {
            foreach (char c in vector)
            {
                Console.Write(c);
            }
        }
        public static void MostrarChar(char[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);

            }

        }
        public static void MostrarVector(int[] vector)
        {
            foreach (int elementos in vector)
            {
                Console.WriteLine(elementos);//en cada vuelta imprime el elemento
            }

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    Console.WriteLine(vector[i]);
            //}
        }
       

        //METODO PARA CONTAR LETRAS 'a'
        public static int ContarLetra(char[] vector)
        {
            int contador = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);

                if (char.ToLower(vector[i]) == 'a')
                {
                    contador++;

                }
            }
            return contador;
        }
        //METODO PARA CONTAR CUALQUIER COSA: QUE ME PASEN EL VALOR Y CONTARLO
        //sirve para contar cualquier letra q yo le pase(vocales, consonantes,caracteres etc)
        public static int ContarLetra1(char[] vector, char valorBuscado)//CON FOR
        {                                               //#&%A puede ser cualquier cosa
            int contador = 0;//contador se recetea dento del metodo
         
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == valorBuscado)
                {
                    contador++;

                }
            }
            return contador;
        }
        public static int ContarLetra2(char[] vector, char valorBuscado)//CON FOREACH
        {
            int contador = 0;//contador se recetea dento del metodo

            foreach (char caracter in vector)
            {
                if(caracter == valorBuscado)
                { 
                   contador++;
                }
                
            }
            return contador;
        }
        //FUNCION CONTAR VOCALES CON VECTOR CONTADORES
        static void ContarVocales(char[] vector)
        {
            //Puedo cambiar el vector de vocales y el contador
            int[] contadorVocales = new int[5];
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' }; //creo otro vector(vector de vocales)
            //for q recorra el vector y en la posicion de i le asigne cero
            for (int i = 0; i < contadorVocales.Length; i++)
            {
                contadorVocales[i] = 0;//guardo un valor adentro de cada elemento del vector
            }

            //ALGORITMO DE BUSQUEDA:
            for (int v = 0; v < vocales.Length; v++) // for recorre cada vocal del vector vocales
            {//Tengo q recorrer el vector completo (vector)
                for (int c = 0; c < vector.Length; c++) //busco en todo el vector
                {
                    if (vocales[v] == vector[c])
                    {
                        contadorVocales[v]++;
                    }
                }
            }
          //VECTORES PARALELOS:
            for (int v = 0; v < vocales.Length; v++)
            {
                Console.WriteLine($"Cantidad de {vocales[v]}:{contadorVocales[v]}");
            }
        }
        static void ContarVocales(char[] vector, char[] vocales)//recibe vector vocales por parametro 
        {
            int[] contadorVocales = new int[vocales.Length];

            for (int i = 0; i < contadorVocales.Length; i++)//for q recorra el vector y en la posicion de i le asigne cero
            {
                contadorVocales[i] = 0;//guardo un valor adentro de cada elemento del vector
            }
            //ALGORITMO DE BUSQUEDA:
            for (int v = 0; v < vocales.Length; v++) // for recorre cada vocal del vector vocales
            {//Tengo q recorrer el vector completo (vector)
                for (int c = 0; c < vector.Length; c++) //busco en todo el vector
                {
                    if (vocales[v] == vector[c])
                    {
                        contadorVocales[v]++;
                    }
                }
            }
        }

            //METODO PARA CAMBIAR POSICION POR SIGNO//REEMPLAZAR VOCALES
        public static void ReemplazarVocal(char[] vector)
        { 
            for (int i = 0; i < vector.Length; i++)//recorro el array(vector) de forma incremental
            {//Comparar cualquiera de las vocales
                //Condicion para comparar:
                if (vector[i] == 'a' || vector[i] == 'e' || vector[i] == 'i' || vector[i] == 'o' || vector[i] == 'u')
                {
                    vector[i] = '$';//letras en la posicion de i es igual al caracter $
                }
            }

        }
 
        //FUNCION PARA ORDENAR VECTOR
        public static void OrdenarVector(int[] vector)
        {
            int auxiliar;
            for (int i = 0; i < vector.Length -1 ; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    //Comparacion de posiciones
                    if (vector[i] < vector[j]) //-> si quiero ordenar al reves: (vectorDeNumeros[i] > vectorDeNumeros[j])
                    {
                        auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                    }
                }
            }
        }
        //FUNCION PARA ORDENAR DE MENOR-MAYOR/MAYOR-MENOR
        public static void OrdenarVector1(int[] vector, bool ascendente)
        {
            int auxiliar;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (ascendente)//si ascendente es verdadero
                    {
                        if (vector[i] > vector[j]) //SI ASCENDENTE ESTA EN TRUE : ME LO MUESTA DE MENOR A MAYOR
                        {
                            auxiliar = vector[i];
                            vector[i] = vector[j];
                            vector[j] = auxiliar;
                        }
                    }
                    else
                    {
                        if (vector[i] < vector[j]) //SI DESCENDENTE ESTA EN FALSE : ME LO MUESTA DE MAYOR A MENOR
                        {
                            auxiliar = vector[i];
                            vector[i] = vector[j];
                            vector[j] = auxiliar;
                        }
                    }
                }
            }
        }
        public static void OrdenarArrayCorregido(char[] vector)
        {

            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        char auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                    }

                }
            }
        }
        public static void ArrayReversa(char[] letras)
        {
            for (int i = letras.Length - 1; i >= 0; i--)
            {
                Console.Write(letras[i]);
               
            }
        }

        //FUNCION PARA INVERTIR VECTOR: alterar el orden
        public static void InvertirArray(char[] v)
        {
            char[] invertido = new char[v.Length];//Array invertido solo vive dentro del metodo

            for (int i = v.Length - 1; i >= 0; i--)
            {
                invertido[v.Length - 1 - i] = v[i];
            }
            //*Conseguir invertido se asigne dentro del array v:
            //quiero q los valores q estan en invertido pasarlos al array de v.
                    //NO PUEDO HACERLO POR ASIGNACION.
                    //v = invertido;//si asigno referencia del array invertido -> no se puede hacer ya q invertido solo existe dentro del metodo

            //Tendria q hacer un for y hacer una copia posicion a posicion
            for (int i = 0; i < invertido.Length; i++) //COPIA PROFUNDA
            {
                v[i] = invertido[i];
            }
        }
        //FUNCION PARA INVERTIR VECTOR CON INTERCAMBIO DE POSICIONES:
        public static void InvertirArrayV2(char[] v) 
        {//no tengo declarado un array invertido y trabajo con el mismo array q recibi por parametro
            int inicio = 0;
            int final = v.Length - 1;//ultima posicion
            char aux;

            while (inicio < final)//Condicion de corte
            {
                aux = v[inicio];
                v[inicio] = v[final];
                v[final] = aux;

                inicio++;//inicio+=1
                final--;//final-=1
            }
        }
        public static int SumarValores(int[] vector)//con for
        {
            int suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            return suma;
        }
        public static int SumarValores1(int[] vector)//foreach
        {
            int suma = 0;
            foreach (int numero in vector)
            {
                suma += numero;
            }
            return suma;
        }
        //METODO PARA SUMAR NUMEROS POSITIVOS
        public static int SumarPositivos(int[] vector)
        {
            int suma = 0;
            foreach (int elemento in vector)
            {
                if (elemento > 0)
                {
                    suma += elemento;
                }
            }
            return suma;
        }
        //METODO PARA MOSTRAR NUMEROS PARES
        public static void MostrarPares(int[] vector)
        {
            foreach (int elemento in vector)
            {
                if (elemento % 2 == 0 && elemento != 0)
                {
                    Console.WriteLine(elemento);
                }
            }
        }
    }
}



       




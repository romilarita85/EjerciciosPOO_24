
using System.Drawing;
using System.Text;

namespace Ejercicios_ListasMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************METODO ADD***************");//ok
            //-Add
            //crea una lista de string. agrega cinco nombres utilizando add. luego, imprime el contenido de la lista.
            List<string> misNombres = new List<string>();
            misNombres.Add("Rosa");
            misNombres.Add("Juan");
            misNombres.Add("Roberto");
            misNombres.Add("Ivan");
            misNombres.Add("Solange");
            MostrarLista(misNombres);
            Console.WriteLine("************METODO ADD RANGE***************");//ok
            //-Addrange
            //crea una lista de números y usa addrange para agregar una colección de números adicionales
            //(por ejemplo, del 10 al 15). muestra el contenido de la lista.
            List<int> misNumeros = new List<int>() {1,2,3,4,5,6};
            MostrarListaInt(misNumeros);
            Console.WriteLine("***************************");
            misNumeros.AddRange(new int[] {7,8,9} );
            MostrarListaInt(misNumeros);
            Console.WriteLine("***************************");
            int[] numerosAgregados = new int[] { 10, 11, 12, 13, 14, 15 };
            misNumeros.AddRange(numerosAgregados);
            MostrarListaInt(misNumeros);
            
            Console.WriteLine("************METODO INSERT***************");//ok
            //-Insert
            //Crea una lista de string y luego inserta el nombre “maría” en la segunda posición.
            //imprime la lista para verificar la posición de "maría".
            List<string>listaMisNombres = new List<string>() {"Juan","Maria Elena","Horacio" };
            MostrarLista(listaMisNombres);
            Console.WriteLine("************Incertando posicion 2***************");
            listaMisNombres.Insert(2, "Maria");
            MostrarLista(listaMisNombres);

            Console.WriteLine("************METODO REMOVE***************");
            //-Remove:
            //crea una lista de ciudades y elimina una ciudad específica (por ejemplo, “roma”) usando remove.
            //Muestra la lista para verificar que la ciudad fue eliminada.
            List<string> ciudades = new List<string>() { "Venecia", "Roma", "Buenos Aires", "Valencia" };
            MostrarLista(ciudades);
            Console.WriteLine("<<<<<<<Eliminando Roma>>>>>>");
            ciudades.Remove("Roma");
            MostrarLista(ciudades);
            Console.WriteLine("************METODO REMOVEAt***************");
            //-Removeat
            ////crea una lista de animales y elimina el tercer elemento utilizando removeat. imprime el resultado.
            List<string> animales = new List<string>() { "leon", "elefante", "oso", "surikata" };
            MostrarLista(animales);
            Console.WriteLine("<<<<<Eliminando tercer elemento de la lista>>>>>>");
            animales.RemoveAt(3);
            MostrarLista(animales);
            Console.WriteLine("************METODO REMOVEALL***************");
            //-Removeall
            //crea una lista de enteros y elimina todos los números pares usando removeall con una
            //condición adecuada. muestra la lista resultante.
            List<int> misNumerosX = new List<int>() {3,12,53,21,8,1,4 }; //ok
            MostrarListaInt(misNumerosX);
            misNumerosX.RemoveAll(numero => numero %2 == 0);
            Console.WriteLine("************Eliminando numeros pares con RemoveAll***************");
            MostrarListaInt(misNumerosX);

            Console.WriteLine("************METODO CLEAR***************");
            //-Clear
            //crea una lista de países. llenarla con cinco nombres de países y luego usa clear para vaciar la lista.
            //muestra el contenido de la lista después de la operación.
            List<string> listaPaises = new List<string>() {"Argentina","Brazil","Colombia","Chile","Uruguay"};
            MostrarLista(listaPaises);
            listaPaises.Count();
            Console.WriteLine("************Usando Clear para vaciar lista***************");
            listaPaises.Clear();
            listaPaises.Count();

            Console.WriteLine("************METODO CONTAINS***************");
            //-Contains
            //crea una lista de colores y verifica si un color específico (por ejemplo, “azul”)
            //está en la lista usando contains. imprime un mensaje con el resultado.
            List<Color> misColores = new List<Color>() {Color.Aqua,Color.Blue,Color.Brown};//ok
            MostrarListaColores(misColores);
            Console.WriteLine("***************");

            if (misColores.Contains(misColores[1]))
            {
                Console.WriteLine("Si, el color esta en la lista ");
            }
            else 
            {
                Console.WriteLine("El color no esta en la lista");
            }
            Console.WriteLine("************METODO INDEXOF***************");
            //-Indexof
            //crea una lista de frutas y usa indexof para encontrar la posición de una fruta (por ejemplo, “manzana”). muestra la posición en la consola.
            List<string> frutas = new List<string>() {"uva","banana","manzana","naranja","manzana" }; //ok
            MostrarLista(frutas);
            Console.WriteLine($"La fruta manzana esta en la posicion: {frutas.IndexOf("manzana")}");
            
            Console.WriteLine("************METODO FIND***************");
            //-Find
            //crea una lista de números y encuentra el primer número mayor que 10 usando find. imprime el número encontrado.
            List<int> listaNumeros = new List<int>() { 1, 5, 29, 8, 31, 0 };//0k
            MostrarListaInt(listaNumeros);
            Console.WriteLine("Primer numero mayor a 10 encontrado");
            Console.WriteLine(listaNumeros.Find(numero => numero > 10));

            Console.WriteLine("************METODO FIDNALL***************");
            //-Findall
            //crea una lista de edades y usa findall para obtener una lista con todas las edades mayores de 18.
            //imprime las edades encontradas.
            List<int>edades = new List<int>(){18,22,8,34,60,2};
            MostrarListaInt(edades);
            Console.WriteLine("************Edades mayores a 18***************");
            List<int> misEdades = edades.FindAll(numero => numero>18);
            Console.WriteLine(misEdades);

            Console.WriteLine("************METODO SORT***************");
            //-Sort
            //crea una lista de números desordenados y usa sort para ordenarlos en orden ascendente.
            //imprime la lista después de ordenar.
            List<int> misNumerosZ = new List<int>() { 15, 48, 8, 38, 0, 2 };
            MostrarListaInt(misNumerosZ);
            Console.WriteLine("******Ordenando de manera ascendente:******");
            misNumerosZ.Sort();
            MostrarListaInt(misNumerosZ);

            Console.WriteLine("************METODO REVERSE***************");
            //Reverse
            //crea una lista de letras, ordénalas y luego usa reverse para invertir su orden. imprime la lista invertida.
            List<char> listaLetras = new List<char>() {'e', 'l' , 'g' , 'a' , 'w' };
            MostrarListaChar(listaLetras);
            listaLetras.Sort();
            Console.WriteLine("************lista de letras ordenada ***************");
            MostrarListaChar(listaLetras);
            listaLetras.Reverse();
            Console.WriteLine("************Aplicando metodo reverse***************");
            MostrarListaChar(listaLetras);

            Console.WriteLine("************METODO COUNT***************");
            //-Count
            //crea una lista de alimentos y usa count para obtener la cantidad de elementos. imprime el resultado.
            List<string> alimentos = new List<string>() {"arroz","pasta","verduras","frutas"};
            MostrarLista(alimentos);
            Console.WriteLine($"La cantidad de elementos de la lista alimientos es: {alimentos.Count()}");
            
            Console.WriteLine("************METODO TOARRAY***************");
            //-Toarray
            //crea una lista de nombres de planetas. usa toarray para convertir la lista en un array
            //y muestra los elementos del array en la consola.
            List<string> planetas = new List<string>() { "Pluton", "Mercurio", "Venus", "Marte" ,"Saturno","Jupiter"};
            string[] misPlanetas = planetas.ToArray();
            foreach (string  p in misPlanetas)
            {
                Console.WriteLine(p);
            }
            
            Console.WriteLine("************METODO FOREACH***************");
            //-foreach
            ////crea una lista de frases y usa foreach para imprimir cada frase en mayúsculas en la consola.
            List<string> frases = new List<string>();
            frases.Add("El unico conocimiento verdadero es saber que no sabes nada - Socrates");
            frases.Add("la vida es muy simple, pero insistimos en hacerla complicada - Anonimo");
            frases.Add("Lo que sabemos es una gota de agua, lo que ignoramos es el océano - Issac Newton");
            frases.Add("Pensar es el dialogo del alma cosigo misma - Platon");
            
            foreach (string fs in frases)
            {
                string misFrases = fs.ToUpper();
                Console.WriteLine(misFrases);   
            }
          

        }
        public static void MostrarLista(List<string> listaNombres) 
        {
            foreach (string nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }
        }
        public static void MostrarListaInt(List<int> listaNumeros)
        {
            foreach (int numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
        }
        public static void MostrarListaColores(List<Color> colores)
        {
            foreach (Color c in colores)
            {
                Console.WriteLine(c);
            }
        }
       
        public static void MostrarListaChar(List<char> caracteres)
        {
            foreach (char caracter in caracteres)
            {
                Console.WriteLine(caracter);
            }
        }
       

    }
}

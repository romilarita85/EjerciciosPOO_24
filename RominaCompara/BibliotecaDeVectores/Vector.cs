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
        public static char[] CargarArray2()// no estoy limitado por la cantidad de letras
        {
            string lectura;

            Console.Write("Ingrese una palabra: ");
            lectura = Console.ReadLine();//readline te devuelve un string

            return lectura.ToCharArray();
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
        //METODO PARA CONTAR VOCALES
        public static int ContarVocales1(char[] vector,char valorBuscado)
        {
            int contadorVocales = 0;
            if (vector != null)
            {
                foreach (char c in vector)
                {
                    if (c == valorBuscado)
                    {
                        contadorVocales++;
                    }
                }
                Console.WriteLine($"La cantidad de vocales del array es: {contadorVocales}");
            }
            else
            {
                Console.WriteLine("Error!! Array no cargado.");
            }
            return contadorVocales;
        }
        public static int ContarVocales(char[] vector)
        {
            int contadorVocales = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);

                char letra = char.ToLower(vector[i]);
                
                if ( letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    contadorVocales++;

                }
            }
            return contadorVocales;
        }

        public static void ReemplazarVocal(char[] vector)
        { 
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 'a' || vector[i] == 'e' || vector[i] == 'i' || vector[i] == 'o' || vector[i] == 'u')
                {
                    vector[i] = '$';
                }
            }
        }
       
        public static void OrdenarArrayCorregido(char[] vector)
        {

            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        char auxiliar = vector[i];
                        vector[i] = vector[j];
                        vector[j] = auxiliar;
                    }

                }
            }
        }
        public static void ArrayReversa(char[] array)
        {

            for (int i = array.Length - 1; i >= 0; i++)
            {
                Console.Write(array[i]);
               
            }
        }


    }
}

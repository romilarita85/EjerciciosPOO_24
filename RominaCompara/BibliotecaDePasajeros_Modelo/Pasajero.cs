namespace BibliotecaDePasajeros_Modelo
{
    public class Pasajero   
    {
       //1. Crear la clase “Pasajero”, que contiene los siguientes atributos privados:
       //● _nombre(string)
       //● _genero(string)
       //● _edad(int)
       //Crear un constructor que inicialice todos los atributos, y propiedades de solo
       //lectura
        private string nombre;
        private string genero;
        private int edad;

        public Pasajero(string nombre, string genero, int edad)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.edad = edad;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Genero
        {
            get 
            {
                return this.genero;
            }
        }
        public int Edad 
        {
            get
            { 
                return this.edad;
            }  
         
        }

        //Métodos y sobrecargas:
        //● Sobrecargar al operador == (Pasajero, Pasajero) para que compare dos
        //pasajeros y determine si son iguales o no.Todos sus atributos deberán ser
        //iguales
        public static bool operator ==(Pasajero p1, Pasajero p2) 
        {
            bool sonIguales = false;

            if (p1.nombre == p2.nombre && p1.genero == p2.genero && p1.edad == p2.edad)
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2) 
        {
            return !(p1 == p2);
        }
    }
}

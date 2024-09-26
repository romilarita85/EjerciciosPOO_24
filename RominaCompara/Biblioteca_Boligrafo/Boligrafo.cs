//Ejercitación programación orientada a objetos

//Una empresa de tecnología nos pide desarrollar un software para su más reciente invención: la “SmartPen”.

//Los requisitos planteados por parte de la empresa son los siguientes:

//⦁	Crear una clase llamada Bolígrafo.

//⦁	Los atributos serán los siguientes: 
//⦁	capacidadTintaMaxima
//⦁	grosorPunta
//⦁	color
//⦁	cantidadTinta

//⦁	Al crearse una nueva instancia de la clase Bolígrafo, la misma siempre se creará con una capacidad
//de tinta máxima de 100 (El constructor no recibirá este parámetro)

//⦁	Al crearse una nueva instancia de la clase Bolígrafo la tinta siempre comenzará siendo de 80 (El constructor no recibirá este parámetro)

//⦁	Al crearse una nueva instancia de la clase Bolígrafo se podrá elegir el color del mismo
//(El constructor recibirá un string indicando el color y lo guardará en el atributo)

//⦁	Al crearse una nueva instancia de la clase Bolígrafo se podrá elegir el grosor de la punta del mismo
//(El constructor recibirá un string indicando el grosor y lo guardará en el atributo) 

//⦁	Los métodos de instancia serán los siguientes:
//⦁	escribir(texto)
//⦁	Deberá validar si el bolígrafo cuenta con la tinta suficiente para escribir el texto: la tinta a ser gastada
//corresponde a la cantidad de caracteres (Ej: el texto “hola” gasta 4 de tinta, si el trazo es fino. Si es grueso gasta el doble )
//⦁	En caso de contar con la tinta suficiente, deberá restarse la cantidad del atributo cantidadTinta y
//devolver una cadena con el texto recibido por parámetro.
//⦁	En caso de no contar con la tinta suficiente deberá retornar la cadena “No alcanza la tinta”.
//⦁	recargar(cantidad)
//-Deberá sumarse la cantidad de tinta recibida por parámetro al atributo cantidadTinta.
//-Deberá validarse que la tinta recargada no supere el valor establecido por el atributo cantidadTintaMaxima.
//(Ej: Si el bolígrafo tiene 50 de tinta y el parámetro cantidad es 60 debe establecerse cantidadTinta en 100,
//no en 110, pues ese es el valor establecido como máximo en el atributo cantidadTintaMaxima.
//-Si la cantidad recargada no excede el máximo deberá retornarse la cadena “Lapicera recargada”.
//- Si la cantidad recargada excede el máximo deberá retornarse la cadena
//“Se recargó la lapicera y sobró __ cantidad de tinta. (Rellenar el espacio con el valor que se haya excedido)


//En el Main de la clase Program, crear un bolígrafo de tinta “Azul” y un grosor “Fino” y otro de tinta “Roja” y un grosor “Grueso”

//Utilizar todos los métodos y mostrar los resultados por consola.
using System.Drawing;

namespace Biblioteca_Boligrafo
{
    public class Boligrafo
    {
        private int capacidadTintaMaxima;
        private string grosorPunta;
        private Color color;
        private int cantidadTinta;

        public Boligrafo(string grosorPunta, Color color)
        {
            this.capacidadTintaMaxima = 100;
            this.grosorPunta = grosorPunta;
            this.color = color;
            this.cantidadTinta = 80;
        }
        //Metodos SET Y GET:
        public void SetCapTintaMax(int capacidad)
        {
            this.capacidadTintaMaxima = capacidad;
        }
        public void SetGrosorPunta(string grosor)
        {
            this.grosorPunta = grosor;
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public void SetCantidadTinta(int cant)
        {
            this.cantidadTinta = cant;
        }
        public int GetCapTintaMax()
        {
            return this.capacidadTintaMaxima;
        }
        public string GetGrosorPunta()
        {
            return this.grosorPunta;
        }
        public Color GetColor()
        {
            return this.color;
        }
        public int GetCantidadTinta()
        {
            return this.cantidadTinta;
        }

        //Metodos
        //-Escribir(texto)
        //⦁	Deberá validar si el bolígrafo cuenta con la tinta suficiente para escribir el texto: la tinta a ser gastada
        //corresponde a la cantidad de caracteres (Ej: el texto “hola” gasta 4 de tinta, si el trazo es fino.
        //Si es grueso gasta el doble )
        //⦁	En caso de contar con la tinta suficiente, deberá restarse la cantidad del atributo cantidadTinta y
        //devolver una cadena con el texto recibido por parámetro.
        //⦁	En caso de no contar con la tinta suficiente deberá retornar la cadena “No alcanza la tinta”.
        public string Escribir(string texto)
        {
            string puedeEscribir = "No alcanza tinta";
            int tintaSuficiente = texto.Length; // Si trazo es fino, es igual a la longitud del texto
            
            if (grosorPunta == "Grueso")
            {
                tintaSuficiente = texto.Length * 2; // Si trazo es grueso, el gasto es el doble
            }

            if (cantidadTinta > tintaSuficiente)
            {
                cantidadTinta -= tintaSuficiente;
                puedeEscribir = "Alcanza la tinta";
            }
            return puedeEscribir;

        }
        //⦁	Recargar(cantidad)
        //-Deberá sumarse la cantidad de tinta recibida por parámetro al atributo cantidadTinta.
        //-Deberá validarse que la tinta recargada no supere el valor establecido por el atributo cantidadTintaMaxima.
        //(Ej: Si el bolígrafo tiene 50 de tinta y el parámetro cantidad es 60 debe establecerse cantidadTinta en 100,
        //no en 110, pues ese es el valor establecido como máximo en el atributo cantidadTintaMaxima.
        //-Si la cantidad recargada no excede el máximo deberá retornarse la cadena “Lapicera recargada”.
        //- Si la cantidad recargada excede el máximo deberá retornarse la cadena
        //“Se recargó la lapicera y sobró __ cantidad de tinta. (Rellenar el espacio con el valor que se haya excedido)

        public string Recargar(int cantidad) //Ver en clase
        {
            string recarga = string.Empty;

            int cantidadTintaRec;
            cantidadTintaRec = this.cantidadTinta + cantidad;

            if (cantidadTintaRec < capacidadTintaMaxima)
            {
                this.cantidadTinta = cantidadTintaRec;
                recarga = "Lapicera recargada";
            }
            else
            {
                int excedenteTinta;
                excedenteTinta = cantidadTintaRec - capacidadTintaMaxima;
                this.cantidadTinta = capacidadTintaMaxima;
                recarga = $"Se recargó la lapicera y sobró {excedenteTinta} cantidad de tinta";
            }

            return recarga;

        }
        public string MostrarInformacion()
        {
            return $" Cap tinta maxima: {capacidadTintaMaxima} - Grosor punta: {grosorPunta} - Color: {color.Name} - Cantidad de tinta: {cantidadTinta}";
        }


    }
}

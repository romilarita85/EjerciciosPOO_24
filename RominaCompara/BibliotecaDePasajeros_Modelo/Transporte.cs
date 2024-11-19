using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaDePasajeros_Modelo
{
    public abstract class Transporte
    {
        //2.Crear una clase llamada “Transporte” que posea los siguientes atributos que sólo
        //deberán ser visibles desde las clases que hereden de ella:
        //● _línea(entero)
        //● _ interno(entero)
        //● _chofer(string)
        //● _cantidadPasajeros(int)
        protected int linea;
        protected int interno;
        protected string chofer;
        protected int cantidadPasajeros;
        
        //Crear un constructor que inicialice todos los atributos y otro que reciba todos
        //menos el chofer.
        public Transporte(int linea, int interno, string chofer, int cantidadPasajeros):this(linea,interno,cantidadPasajeros)
        {
             this.chofer = chofer;
        }
        public Transporte(int linea, int interno, int cantidadPasajeros) 
        {
            this.linea = linea;
            this.interno = interno;
            this.cantidadPasajeros = cantidadPasajeros;
        }
        

        //Y los siguientes métodos públicos:
        //● string SacarBoleto(string): retorna un mensaje con el destino recibido como
        //parámetro junto a la fecha del viaje. Este método será virtual.
        public virtual string SacarBoleto(string destino) 
        {
            string msje = $"Destino:{destino}  - Fecha de viaje:{DateTime.Now} ";
            return msje;
        }

        //● string SacarBoleto(string, Pasajero): este método llamará a SacarBoleto y
        //en caso que el pasajero no sea nulo sumará el nombre del pasajero al
        //mensaje. Este método será virtual.

        public virtual string SacarBoleto(string destino, Pasajero p) 
        {
            string mensaje = $" {this.SacarBoleto(destino)}"; 
            
            if (p is not null)
            { 
                mensaje += $" - Pasajero {p.Nombre}";

            }
            return mensaje;
        }
        //● string ServirComida(string): Este método será abstracto.

        public abstract string ServirComida();
    }
}

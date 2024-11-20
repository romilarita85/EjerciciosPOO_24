using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BibliotecaDePasajeros_Modelo
{
    public class CortaDistancia:Transporte
    {
        //3. Crear una clase llamada “CortaDistancia” que herede de “Transporte” y que posea
        //el siguiente atributo:
        //● _cantidadDeParadas(int): indica la cantidad de paradas que realiza el
        //transporte de corta distancia desde que inicia su recorrido hasta que finaliza.

        private int cantidadDeParadas;

        //Crear los constructores necesarios. Agregar también propiedades de solo
        //lectura para su atributo.
        public CortaDistancia(int linea, int interno, string chofer, int cantidadPasajeros, int cantidadDeParadas)
            : base(linea, interno, chofer, cantidadPasajeros)
        {
          
            this.cantidadDeParadas = cantidadDeParadas;
        }
        public int CantidadDeParadas
        {
            get 
            { 
                return this.cantidadDeParadas; 
            }
        }

        //Métodos y sobreescritura:
        //● Sobreescribir el método SacarBoleto(string). Solo se podrá sacar boleto si
        //aún hay paradas y capacidad dentro del transporte. El método disminuye en
        //1 la cantidad de pasajeros y retorna el mensaje de la clase base. En caso
        //que no haya capacidad o más paradas, retorna el mensaje “Imposible subir
        //pasajero”.
        public override string SacarBoleto(string destino)
        {
            string msje= "Imposible subir pasajeros";//en caso de q no alla capacidad o mas paradas;
           
            if (this.cantidadDeParadas > 0 && this.cantidadPasajeros > 0)
            {
                this.cantidadPasajeros = this.cantidadPasajeros - 1; //El método disminuye en 1 la cantidad de pasajeros 
                      
                msje = $"{base.SacarBoleto(destino)}"; //y retorna el mensaje de la clase base.
            }
           
            return msje;
        }


        //● Sobreescribir el método ServirComida: en este caso el método retorna un
        //string con el mensaje: “Servicio no disponible”.
        public override string ServirComida()
        {
            return "Servicio no disponible";
        }

        //● Crear el método void RealizarRecorrido(int): disminuye la cantidad de
        //paradas en el valor recibido como parámetro.
        public void RealizarRecorrido(int valor) //decrementar contador
        {
            this.cantidadDeParadas = this.cantidadDeParadas - valor;
        }
    }
}

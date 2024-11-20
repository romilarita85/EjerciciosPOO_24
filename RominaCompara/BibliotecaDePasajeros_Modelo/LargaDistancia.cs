using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDePasajeros_Modelo
{
    public class LargaDistancia:Transporte
    {
        //4. Crear una clase llamada “LargaDistancia” que herede de “Transporte”, que posea
        //el atributo:
        //● _pasajerosABordo(List<Pasajero>): cantidad de pasajeros que compraron
        //un boleto.
        private List<Pasajero> pasajerosABordo;

        //public LargaDistancia()
        //{
        //    pasajerosABordo = new List<Pasajero>();
        //}

        public LargaDistancia(int linea, int interno, string chofer, int cantidadPasajeros,List<Pasajero>pasajerosABordo)
            :base(linea, interno, chofer, cantidadPasajeros)
        {
            pasajerosABordo = new List<Pasajero>();
        }

        //Métodos, sobrecargas y sobreescritura:
        //● Sobrecargar el operador == (LargaDistancia, Pasajero): para que la misma
        //determine si un pasajero se encuentra o no dentro de la lista.
        public static bool operator ==(LargaDistancia l, Pasajero p) 
        {
            bool seEncuentra = false;

            if (l.pasajerosABordo is not null) 
            {
                foreach  (Pasajero item in l.pasajerosABordo)
                {
                    if (item == p)
                    {
                        seEncuentra = true;
                        break;
                    }
                }
            }
            return seEncuentra;
        }

        public static bool operator !=(LargaDistancia l, Pasajero p)
        {
            return !(l==p);
        }
        //● Sobrecargar al operador + (LargaDistancia, Pasajero): para que agregue
        //un pasajero a la lista de pasajeros, solo si hay espacio en la lista y si el
        //pasajero no se encuentra en la misma.
        public static bool operator +(LargaDistancia l, Pasajero p) 
        {
            bool result = false;

            if (l.pasajerosABordo.Count < l.cantidadPasajeros &&  l != p ) // Si hay espacio 
            {
                l.pasajerosABordo.Add(p); // Agrega el pasajero
                result = true;
            }
  
            return result;
        }

        //● Sobreescribir el método SacarBoleto(string, Pasajero). El método verifica
        //que la lista no haya alcanzado la cantidad máxima de pasajeros, y que el
        //mismo no esté en la lista (utilizando el operador ==). Si se cumplen estas
        //condiciones, lo agrega utilizando el operador +. En este caso retorna el
        //mensaje de la clase base. En caso contrario retorna el mensaje “Imposible
        //subir pasajero”.
        public override string SacarBoleto(string destino, Pasajero p)
        {
            string result = "Imposible subir pasajero";

            if (this + p)
            { 
                result = base.SacarBoleto(destino,p); // Llamada al método base
            
            }
            return result;
        }

        //● Sobreescribir el método ServirComida: en este caso el método retorna un
        //string con el mensaje: “La comida está servida. Menú del día: pollo o pasta”.
        public override string ServirComida()
        {
            return "La comida está servida. Menú del día: pollo o pasta";
        }
        //Metodo q me dice si esta o no el pasajero:
        public static bool BuscarPasajero(List<Pasajero> lista, Pasajero p) 
        {
            bool resultado = false;
            foreach (Pasajero item in lista)
            {
                if (item == p)
                {
                    resultado = true;
                    break;
                }
            }
            return resultado;
        }
       

    }
}

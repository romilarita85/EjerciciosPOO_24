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

        public LargaDistancia(int linea, int interno, string chofer, int cantidadPasajeros)
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
            foreach  (Pasajero item in l.pasajerosABordo)
            {
                if (item == p)
                {
                    seEncuentra = true;
                }
            }
            return seEncuentra;
        }

        public static bool operator !=(LargaDistancia l, Pasajero p)
        {
            return !(l == p);
        }
        //● Sobrecargar al operador + (LargaDistancia, Pasajero): para que agregue
        //un pasajero a la lista de pasajeros, solo si hay espacio en la lista y si el
        //pasajero no se encuentra en la misma.
        public static LargaDistancia operator +(LargaDistancia l, Pasajero p) 
        {
            bool hayEspacio = false;
            bool existePasajero = false;
            
            //Verificamos si el pasajero ya está en la lista
            if (l.pasajerosABordo.Contains(p))
            {
                existePasajero = true;//pasajero esta en la lista
            }
            //Verificamos si hay espacio en el transporte
            
            if (l.pasajerosABordo.Count < l.cantidadPasajeros)
            {
                hayEspacio =true;
            }
            // Si hay espacio y el pasajero no está en la lista, lo agregamos
            if (!existePasajero && hayEspacio)
            {
                l.pasajerosABordo.Add(p);
            }

            return l; // Retornamos el objeto LargaDistancia modificado
        }

        //● Sobreescribir el método SacarBoleto(string, Pasajero). El método verifica
        //que la lista no haya alcanzado la cantidad máxima de pasajeros, y que el
        //mismo no esté en la lista (utilizando el operador ==). Si se cumplen estas
        //condiciones, lo agrega utilizando el operador +. En este caso retorna el
        //mensaje de la clase base. En caso contrario retorna el mensaje “Imposible
        //subir pasajero”.
        public override string SacarBoleto(string mensaje, Pasajero p)
        {
            string msje = "Imposible subir pasajeros";
            

            return msje;
        }

        //● Sobreescribir el método ServirComida: en este caso el método retorna un
        //string con el mensaje: “La comida está servida. Menú del día: pollo o pasta”.
        public override string ServirComida()
        {
            return "La comida está servida. Menú del día: pollo o pasta";
        }

    }
}

//Generar la clase Estante.
//1.Posee dos atributos privados. Uno será un entero que indicará la ubicación
//del estante y el otro es un array de tipo Producto.
//2. El constructor de instancia privado será el único que incializará el array. La
//sobrecarga pública del constructor inicializará la ubicación del estante,
//recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
//3. El método público GetProductos, retornará el array de productos. Se
//recomienda usar una propiedad de solo lectura.
//4. El método público de clase (estático) MostrarEstante, retornará una
//cadena con toda la información del estante incluyendo el detalle de cada uno
//de sus productos. Reutilizar código.
//5. Posee las siguientes sobrecargas de operadores:
//i. ==: Retornará true si es que el producto ya se encuentra en el estante,
//false caso contrario.

//ii. +: Retornará true y agregará el producto si el estante posee
//capacidad de almacenar al menos un producto más y dicho producto
//no se encuentra en el estante, false caso contrario. Reutilizar código.
//iii. -: Retornará un estante sin el producto, siempre y cuando el producto
//se encuentre en el listado. Reutilizar código.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeProductos
{
    public class Estante
    {//1.Posee dos atributos privados. Uno será un entero que indicará la ubicación
     //del estante y el otro es un array de tipo Producto.
        private Producto[] productos;
        private int ubicacionEstante;

        //2. El constructor de instancia privado será el único que incializará el array
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        //La sobrecarga pública del constructor inicializará la ubicación del estante,
        //recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        //3. El método público GetProductos, retornará el array de productos. Se
        //recomienda usar una propiedad de solo lectura.

        public Producto[] Productos
        {
            get
            {
                return this.productos;
            }

        }

        //4. El método público de clase (estático) MostrarEstante, retornará una
        //cadena con toda la información del estante incluyendo el detalle de cada uno
        //de sus productos. Reutilizar código.
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion del Estante {e.ubicacionEstante}");
            sb.AppendLine("Productos: ");

            foreach (Producto item in e.productos)
            {
                if (item is not null) //si objeto no es nulo -mostralo
                {
                    sb.AppendLine(Producto.MostrarProducto(item));
                }
            }
            return sb.ToString();
        }

        //5. Posee las siguientes sobrecargas de operadores:
        //i. ==: Retornará true si es que el producto ya se encuentra en el estante,
        //false caso contrario.
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool seEncuentra = false;
            foreach (Producto item in e.productos) 
            {
                if (item == p)//el producto ya se encuentra en el estante,
                {
                    seEncuentra = true;
                }
            }
            return seEncuentra;
        }

        //ii. +: Retornará true y agregará el producto si el estante posee
        //capacidad de almacenar al menos un producto más y dicho producto
        //no se encuentra en el estante,
        //false caso contrario. Reutilizar código.
        public static bool operator +(Estante e, Producto p)
        {
            bool poseeCap = false;

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is null)//*si es nulo puedo utilizarlo por q esta vacio
                { 
                    poseeCap = true;
                    e.productos[i] = p;//*Guarda en una posicion un elemento del tipo producto:
                                       //guardar p dentro del array
                    break; 
                }
                
            }
            return poseeCap;
        }

        //iii. -: Retornará un estante sin el producto, siempre y cuando el producto
        //se encuentre en el listado. Reutilizar código.
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
               
                if (e.productos[i] == p) //se encuentra
                {
                    e.productos[i] = null;
                   
                    break;
                }
            }
            return e;  
        }

        public static int ObtenerIndiceLibre(Producto[] vector) //preciso recibir un array del tipo producto
        {//int por q quiero saber el numero de la posicion
            int indice = -1;//indice q nunca voy a poder utilizar -1
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] is null)//si encuentra una posicion nula(vacia)
                {
                    indice = i;//obtengo el indice
                    break;
                }
            }
            return indice;
        }
    }
}

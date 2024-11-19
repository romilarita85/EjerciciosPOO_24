//TP-Ejercicio 2
//Crear un proyecto de tipo biblioteca de clases que contenga la clase Producto
//1.Todos sus atributos son privados.
//2. Posee sólo un constructor de instancia.
//3. El método GetMarca, retornará el valor correspondiente al atributo marca. Se
//recomienda utilizar una propiedad de solo lectura.
//4. También poseerá el atributo codigoDeBarras, el cual se publicará sólo a
//través de la conversión explícita nombrada más adelante.
//5. El método de clase (estático) MostrarProducto es público y retornará una
//cadena detallando los atributos de la clase.
//6. Posee las siguientes sobrecargas de operadores:
//i. explicit: Realizará la conversión de un objeto Producto a string.
//Sólo retornará el atributo codigoDeBarras del producto.
//ii. == (Producto, Producto): Retornará true si las marcas y
//códigos de barra son iguales, false caso contrario.
//Centro de formación profesional N°6
//iii. == (Producto, string): Retornará true si la marca del producto
//coincide con la cadena pasada como argumento, false caso
//contrario.
using BibliotecaDeProductos;
using Microsoft.VisualBasic;
using System.Numerics;
using System.Text.RegularExpressions;
namespace BibliotecaDeProductos
{
    public class Producto
    {//1.Todos sus atributos son privados.
        private string codigoDeBarras;
        private string marca;
        private float precio;

        //2. Posee sólo un constructor de instancia.
        public Producto(string codigoDeBarras, string marca, float precio)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.marca = marca;
            this.precio = precio;
        }
        //3. El método GetMarca, retornará el valor correspondiente al atributo marca. Se
        //recomienda utilizar una propiedad de solo lectura.
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }
        public float Precio
        {
            get
            {
                return this.precio;
            }
        }
        //4. También poseerá el atributo codigoDeBarras, el cual se publicará sólo a
        //través de la conversión explícita nombrada más adelante.
        

        //5. El método de clase (estático) MostrarProducto es público y retornará una
        //cadena detallando los atributos de la clase.
        public static string MostrarProducto(Producto p) 
        {
            return $"Codigo de barras: {p.codigoDeBarras} - Marca: {p.marca} - Precio: {p.precio}";   
        }

        //6. Posee las siguientes sobrecargas de operadores:

        //i. explicit: Realizará la conversión de un objeto Producto a string.
        //Sólo retornará el atributo codigoDeBarras del producto.
        public static explicit operator string(Producto p)
        {
            string cod = "";
            cod = p.codigoDeBarras;
            return cod;
            //return p.codigoDeBarras; 
        }

        //ii. == (Producto, Producto): Retornará true si las marcas y
        //códigos de barra son iguales, false caso contrario.
        public static bool operator !=(Producto p1, Producto p2) 
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, Producto p2) 
        {
            bool sonIguales = false;
            if (p1.marca == p2.marca && p1.codigoDeBarras == p2.codigoDeBarras) 
            { 
                sonIguales = true;  
            }
            return sonIguales;
        }

        //iii. == (Producto, string): Retornará true si la marca del producto
        //coincide con la cadena pasada como argumento, false caso
        //contrario.
        public static bool operator !=(Producto p, string marca) //dato-marca q paso por parametro
        {
            return !(p.marca == marca);
        }
        public static bool operator ==(Producto p, string marca)
        {
            bool coincide = false;
            if (p.marca == marca)
            {
                coincide = true;
            }
            return coincide;
        }
    }
}

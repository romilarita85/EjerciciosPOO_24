using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaDeVehiculos
{
    public enum EMarcas 
    {
        Ford, Ferrari, Lotus
    }
    public class Auto:Vehiculo
    {
        private EMarcas marca;

        //public Auto(EMarcas marca)
        //{
        //    this.marca = marca;
        //}

        //○ Tres constructores sobrecargados para instanciar objetos Auto pasando
        //diferentes combinaciones de parámetros:
        //■ La marca y el color.
        public Auto(EMarcas marca, string color) : base(color)
        {
            this.marca = marca;
        }
        //■ La marca, color y el precio.
        public Auto(EMarcas marca, string color, double precio) : this(marca, color)
        {
            this.precio = precio;
        }
        //■ Todos los atributos(Marca, Color, Precio, Nacionalidad).

        public Auto(EMarcas marca, string color, double precio, string nacionalidad) : this(marca,color,precio)
        {
            this.nacionalidad = nacionalidad;
        }
        //○ Implementar el método AgregarImpuestos(double impuesto) para
        //incrementar el precio.
        public override double AgregarImpuesto(double impuesto)
        {
            this.precio += impuesto;
            //this.precio = this.precio + impuesto;
            return this.precio;
        }
        //○ Sobrescribir el método Mostrar() para mostrar también la Marca.
        public override string Mostrar()
        {
            return $"{base.Mostrar()}-Marca: {marca}";
        }
        //○ Sobrecargar el operador == para comparar dos objetos de tipo Auto.Solo
        //devolverá true si ambos Auto tienen la misma marca y nacionalidad.
        public static bool operator ==(Auto a1, Auto a2) 
        {
            bool sonIguales = false;
            if (a1.marca == a2.marca && a1.nacionalidad == a2.nacionalidad)
            {
                sonIguales = true;
            }

            return sonIguales;
        }
        public static bool operator !=(Auto a1, Auto a2) 
        {
            return !(a1 == a2);
        }
        //○ Sobrecargar el operador + para permitir sumar dos objetos Auto. Retornará
        //la suma de los precios solo si ambos autos tienen la misma marca,
        //nacionalidad y color; de lo contrario, devolverá cero.
        public static double operator +(Auto a1, Auto a2) 
        {
            double result = 0;
            if (a1 == a2 && a1.color == a2.color)
            {
                result = a1.precio + a2.precio;
            }
            return result;
        }
    }
}

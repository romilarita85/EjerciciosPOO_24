using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
namespace BibliotecaDeVehiculos
{

    public class Camioneta:Vehiculo
   {
        //    3. Crear una clase Camioneta que herede de Vehiculo y que contenga:
        //○ Atributo privado:
        //■ CapacidadCarga(double) que indique la capacidad de carga de la
        //camioneta en kilogramos.
        private double capacidadCarga;

        //○ Un constructor que permita inicializar todos sus atributos(Color, Precio,
        //Nacionalidad, CapacidadCarga).
        public Camioneta(string color, double precio, string nacionalidad,double capacidadCarga) : base(color, precio, nacionalidad)
        {
            this.capacidadCarga = capacidadCarga;
        }
        //○ Implementar el método AgregarImpuestos(double impuesto) para
        //incrementar el precio.
        public override double AgregarImpuesto(double impuesto)
        {
            double suma;
            suma = this.precio + impuesto;
            return suma;
        }
        //○ Sobrescribir el método Mostrar() para mostrar todos los atributos,
        //incluyendo la CapacidadCarga.
        public override string Mostrar()
        {
            return $"{base.Mostrar()} - Cap. de Carga: {this.capacidadCarga}";
        }

    }
}

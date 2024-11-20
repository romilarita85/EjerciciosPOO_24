using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bonus: Clase Garage
//1.Crear una clase llamada Garage que contenga:
//○ Atributos privados:
//■ RazonSocial(string) — Razón social del garage.
//■ PrecioPorHora (double) — Precio por hora de uso.
//■ Vehiculos (lista de Vehiculo) — Lista de vehículos que se
//encuentran en el garage.
//○ Sobrecargar su constructor para permitir instanciar objetos Garage:
//■ El constructor público recibe la razón social y el precio por hora.
//■ El constructor por defecto debe ser privado y debe inicializar la lista
//de Vehiculos.
//2. Métodos de Garage:
//○ Método de instancia MostrarGarage() que no reciba parámetros y que
//muestre todos los atributos del objeto, incluyendo la lista de vehículos
//(usando polimorfismo para mostrar distintos tipos de vehículos).
//3. Sobrecargar el operador == para comparar un objeto de tipo Garage con un objeto
//de tipo Vehiculo. Solo devolverá true si el vehículo ya se encuentra en el garage
//(esto es, si está en la lista Vehiculos).
//4. Sobrecargar el operador + para que permita agregar un objeto Vehiculo al
//Garage. Solo permitirá la adición si el vehículo no está en el garage (usando la
//sobrecarga del operador ==) y retornara true. Si el vehículo ya se encuentra no se
//agregara y retornara false.
//5. En el método Main:
//○ Crear una instancia de Garage.
//○ Agregar distintos vehículos (tanto Auto como Camioneta) al Garage
//usando el operador +.
//○ Intentar agregar el mismo vehículo dos veces para verificar que la restricción
//funciona correctamente.
//○ Usar el método MostrarGarage() para mostrar el estado final del garage y
//la lista de vehículos almacenados

namespace BibliotecaDeVehiculos
{
    public  class Garage
    {
        //1.Crear una clase llamada Garage que contenga:
        //○ Atributos privados:
        //■ RazonSocial(string) — Razón social del garage.
        //■ PrecioPorHora (double) — Precio por hora de uso.
        //■ Vehiculos (lista de Vehiculo) — Lista de vehículos que se
        //encuentran en el garage.
        private string razonSocial;
        private double precioPorHora;
        private List<Vehiculo>listaVehiculos;

        //○ Sobrecargar su constructor para permitir instanciar objetos Garage:
        //■ El constructor público recibe la razón social y el precio por hora.
        public Garage(string razonSocial, double precioPorHora,List<Vehiculo>listaVehiculos):this()
        {
            this.razonSocial = razonSocial;
            this.precioPorHora = precioPorHora;
        }

        //■ El constructor por defecto debe ser privado y debe inicializar la lista
        //de Vehiculos.
        public Garage() 
        {
            listaVehiculos = new List<Vehiculo>();
        }
        //2. Métodos de Garage:
        //○ Método de instancia MostrarGarage() que no reciba parámetros y que
        //muestre todos los atributos del objeto, incluyendo la lista de vehículos
        //(usando polimorfismo para mostrar distintos tipos de vehículos).
        public string MostrarGarage() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Precio por hora: {this.precioPorHora}");
            sb.AppendLine($"Lista de vehiculos");

            if (listaVehiculos is not null) 
            {
                foreach (Vehiculo item in listaVehiculos)
                {
                    sb.AppendLine(item.Mostrar());
                }
            }

            return sb.ToString();
        }

        //3. Sobrecargar el operador == para comparar un objeto de tipo Garage con un objeto
        //de tipo Vehiculo. Solo devolverá true si el vehículo ya se encuentra en el garage
        //(esto es, si está en la lista Vehiculos).
        public static bool operator ==(Garage g, Vehiculo v) 
        {
            bool existe = false;

            if (g.listaVehiculos is not null) 
            {
                foreach (Vehiculo miVehiculo in g.listaVehiculos)
                {
                    if (miVehiculo == v)
                    { 
                        existe = true;
                    }
                }
            }

            return existe;
        }
        public static bool operator !=(Garage g, Vehiculo v) 
        {
            return !(g == v);
        }
        //4. Sobrecargar el operador + para que permita agregar un objeto Vehiculo al
        //Garage. Solo permitirá la adición si el vehículo no está en el garage (usando la
        //sobrecarga del operador ==) y retornara true. Si el vehículo ya se encuentra no se
        //agregara y retornara false.
        public static bool operator +(Garage g, Vehiculo v) 
        {
            bool seEncuentra = false;
            if (!(g==v))
            {
                g.listaVehiculos.Add(v);
                seEncuentra = true;
            }

            return seEncuentra;
        }
    }
}

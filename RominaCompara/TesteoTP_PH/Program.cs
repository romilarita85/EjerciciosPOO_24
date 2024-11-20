using BibliotecaDeVehiculos;
using System.Drawing;

namespace TesteoTP_PH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.En el método Main:
            //○ Crear al menos dos objetos Auto de la misma marca y distinto color.
            Auto auto1 = new Auto(EMarcas.Ford, "rojo");
            Auto auto2 = new Auto(EMarcas.Ford, "rojo");
            //○ Crear dos objetos Auto de la misma marca, mismo color y diferente precio.
            Auto auto3 = new Auto(EMarcas.Ford, "rojo",200000.5);
            Auto auto4 = new Auto(EMarcas.Ford, "rojo",300000.5);

            //○ Crear tres objetos Auto utilizando las tres sobrecargas de constructor.
            Auto auto5 = new Auto(EMarcas.Ferrari,"negro");
            Auto auto6 = new Auto(EMarcas.Ford, "blanco", 100000.5);
            Auto auto7 = new Auto(EMarcas.Lotus, "verde", 150000.9, "Argentina");
            Auto auto8 = new Auto(EMarcas.Lotus, "verde", 150000.9, "Argentina");

            //○ Crear una instancia de Camioneta con sus atributos específicos.
            Camioneta camioneta1 = new Camioneta("rojo", 100000.5, "China", 200.8);

            //○ Usar el método AgregarImpuestos() en los últimos tres objetos Auto,
            //agregando $1000 al precio.
            auto5.AgregarImpuesto(1000);
            auto6.AgregarImpuesto(1000);
            auto7.AgregarImpuesto(1000);

            //○ Calcular la suma de los precios de dos autos usando la sobrecarga del
            //operador + y mostrar el resultado por consola.
            double sum;
            sum = auto7 + auto8;
            Console.WriteLine($"La suma de auto 7 y auto 8 es: {sum}");
            //○ Comparar el primer Auto con el segundo y quinto objeto y mostrar en
            //consola si son iguales o no.
            
            if (auto1 == auto2)
            {
                Console.WriteLine("Auto1 y Auto2 son iguales");
            }
            else 
            {
                Console.WriteLine("Auto1 y Auto2 son distintos");
            }

            if (auto1 == auto5)
            {
                Console.WriteLine("Auto1 y Auto5 son iguales");
            }
            else
            {
                Console.WriteLine("Auto1 y Auto5 son distintos");
            }

            //○ Usar el método Mostrar() para mostrar la información de todos los
            //vehículos creados.
            Console.WriteLine(auto1.Mostrar());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(auto2.Mostrar());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(auto3.Mostrar());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(auto4.Mostrar());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(auto5.Mostrar());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(auto6.Mostrar());
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(auto7.Mostrar());
            //5. En el método Main:
            //○ Crear una instancia de Garage.
            List<Vehiculo> listaDeV = new List<Vehiculo>();
            Garage garage1 = new Garage("Medife", 300, listaDeV);
            //○ Agregar distintos vehículos (tanto Auto como Camioneta) al Garage
            //usando el operador +.

            if (garage1 + auto1)
            {
                Console.WriteLine("Se agrego auto1 al garage1");
            }
            else 
            {
                Console.WriteLine("No se pudo agregar auto1 al garage1");
            }
            if (garage1 + camioneta1)
            {
                Console.WriteLine("Se agrego camioneta1 al garage1");
            }
            else
            {
                Console.WriteLine("No se pudo agregar camioneta1 al garage1");
            }
            //○ Intentar agregar el mismo vehículo dos veces para verificar que la restricción
            //funciona correctamente.
            if (garage1 + auto1)
            {
                Console.WriteLine("Se agrego auto1 al garage1");
            }
            else
            {
                Console.WriteLine("No se pudo agregar auto1 al garage1");
            }
            //○ Usar el método MostrarGarage() para mostrar el estado final del garage y
            //la lista de vehículos almacenados

            Console.WriteLine(garage1.MostrarGarage());

        }
    }
}

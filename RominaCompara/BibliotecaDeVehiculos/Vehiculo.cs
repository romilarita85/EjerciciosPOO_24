//Ejercicio: Transporte con Herencia y Polimorfismo
//1. Crear una clase abstracta llamada Vehiculo que contenga:
//○ Atributos protegidos:
//■ Color(string)
//■ Precio(double)
//■ Nacionalidad(string)
//○ Dos constructores, uno que reciba solo el color y otro que reciba todos los
//atributos.
//○ Un método abstracto AgregarImpuestos(double impuesto) que sume
//el valor recibido al precio del vehículo y retorne dicho valor.
//○ Un método virtual Mostrar(), que retorne un string con los atributos del
//vehículo (Color, Precio y Nacionalidad).

namespace BibliotecaDeVehiculos
{
    public class Vehiculo
    {
        protected string color;
        protected double precio;
        protected double nacionalidad;
        

    }
}

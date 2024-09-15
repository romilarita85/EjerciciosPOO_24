//Ejercicio_05:
//Una empresa que se dedica a la comercialización de lámparas de bajo consumo,registra de sus ventas,
//los siguientes datos: marca y cantidad. El precio de cada lamparita es de $150 (Sin importar la marca).
// El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
// Si compra 6 lamparitas o más, tiene un descuento del 50%.
// Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40% y si es de otra marca, el descuento es del 30%.
// Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25%, y si es de
// otra marca el descuento es del 20%.
// Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%, si es “FelipeLamparas se hace un descuento
// del 10% y si es otra marca, 5%.
// Si el importe final con descuento suma más de $950, se debe agregar el 10% de ingresos brutos.
// Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con
// descuento, y si corresponde total de ingresos brutos y total a pagar
namespace Ejercicio_05Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca;
            int cantidad;
            int precio = 150;
            double precioTotal;//total sin des
            double desc = 0;
            double valorDesc = 0;
            double totalConDesc = 0;
            double iibb = 0.10;
            double valorIIBB = 0;
            double totalConIIBB = 0;

         
            cantidad = PedirInt("Ingrese la cantidad de lamparitas");
            marca = PedirDatos("Ingrese la marca");

            precioTotal = cantidad * precio;

            if (cantidad >= 6) // Si compra 6 lamparitas o más, tiene un descuento del 50%.
            {
                desc = 0.50;
            }
            else
            {
                if (cantidad == 5)// Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40% y si es de otra marca,             
                {//el descuento es del 30%.
                    if (marca == "argentinaluz")
                    {
                        desc = 0.40;
                    }
                    else
                    {
                        desc = 0.30;
                    }
                }
                else
                {
                    if (cantidad == 4)// Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas”            
                    { //se hace un descuento del 25%, y si es de otra marca el descuento es del 20%.
                        if (marca == "argentinaluz" || marca == "felipelamparas")
                        {
                            desc = 0.25;
                        }
                        else
                        {
                            desc = 0.20;
                        }
                    }
                    else
                    {
                        if (cantidad == 3)// Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%,          
                        {//si es “FelipeLamparas se hace un descuento del 10% y si es otra marca, 5%.
                            if (marca == "argentinaluz")
                            {
                                desc = 0.15;
                            }
                            else
                            {
                                if (marca == "felipelamparas")
                                {
                                    desc = 0.10;
                                }
                                else
                                {
                                    desc = 0.05;
                                }
                            }
                        }
                    }
                }
            }
            // Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con
            // descuento, y si corresponde total de ingresos brutos y total a pagar
            Console.WriteLine($"La cantidad de lamparitas es: {cantidad}");
            Console.WriteLine($"La marca es: {marca}");
            Console.WriteLine($"El total sin descuento es: {precioTotal}");

            if (desc != 0)
            {
                valorDesc = CalcularValDesc(precioTotal,desc);
                totalConDesc = CalcularValorTCDesc(precioTotal,valorDesc);
                Console.WriteLine($"El descuento aplicado es: {valorDesc}");
                Console.WriteLine($"El total con descuento es: {totalConDesc}");
            }
            if (totalConDesc >= 950)
            { // Si el importe final con descuento suma más de $950, se debe agregar el 10% de ingresos brutos.
                valorIIBB = CalcularValIIBB(totalConDesc,iibb);
                totalConIIBB = CalcularTotalIIBB(precioTotal,valorIIBB);

                Console.WriteLine($"Total de ingresos brutos: {valorIIBB}");
                Console.WriteLine($"Total a pagar con Ingresos brutos: {totalConIIBB}");

            }

        }
        public static int PedirInt(string mensaje) 
        {
            int resultado;
            string lectura;
            Console.Write(mensaje);
            lectura = Console.ReadLine();
            resultado = int.Parse(lectura);
            return resultado;
        }
        public static string PedirDatos(string msj) 
        {
            Console.Write(msj);
            return Console.ReadLine();
        }
       
        public static double CalcularValorTCDesc(double valor, double porcentaje)
        {
            double resultado;
            resultado = valor - CalcularValDesc(valor, porcentaje);
            return resultado;
        }
        public static double CalcularValDesc(double monto, double porcentaje) 
        {
            double resultado;
            resultado = monto * porcentaje;
            return resultado;
        }
        public static double CalcularValIIBB(double monto, double porcentajeIIBB)
        {
            double resultado;
            resultado = monto * porcentajeIIBB;
            return resultado;
        }
        public static double CalcularTotalIIBB(double valor, double porcentajeIIBB)
        {
            double resultado;
            resultado = valor + CalcularValIIBB(valor, porcentajeIIBB);
            return resultado;
        }
  
    }
}

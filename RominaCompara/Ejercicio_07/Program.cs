//Ejercicio_07:
//Cajero Automático. A partir del ingreso de un monto en pesos (valor entero)
//debemos indicar cuántos billetes de cada valor deberá entregar nuestro cajero automático.
//Tener en cuenta que tenemos que entregar la menor cantidad de billetes posibles.
//Deberán utilizar colores en consola.
// Por ejemplo:
// Importe $2825
// Billetes de $1000: 2
// Billetes de $500: 1
// Billetes de $200: 1
// Billetes de $100: 1
// Billetes de $50: 0
// Billetes de $20: 1
// Billetes de $10: 0
// Sobran $5
using System.Diagnostics;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monto;
            int cantBilletes = 0;
            string tipoBillete;
            string billete1000 = null ;
            string billete500 = null ;
            string billete200 = null;
            string billete100 = null;
            string billete50 = null ;
            string billete20 = null;
            string billete10 =null;
            string billetesSobrant = null;
            int cantBilletes1000 = 0;
            int cantBilletes500 = 0;
            int cantBilletes200 = 0;
            int cantBilletes100 = 0;
            int cantBilletes50 = 0;
            int cantBilletes20 = 0;
            int cantBilletes10 = 0;
            int cantBilletesSobrant = 0;

            Console.WriteLine("Ingrese un monto total de dinero en $(pesos)");
            monto = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique el tipo de billetes por valor");
            Console.WriteLine(">$1000");
            Console.WriteLine(">$500");
            Console.WriteLine(">$200");
            Console.WriteLine(">$100");
            Console.WriteLine(">$50");
            Console.WriteLine(">$20");
            Console.WriteLine(">$10");
            Console.WriteLine(">$5");

            
            //Ver codigo-revisar
            if ((tipoBillete = Console.ReadLine()) == billete1000) 
            {
                Console.WriteLine("Indique la cantidad de billetes de $1000");
                
                cantBilletes1000 = cantBilletes1000 + 1;
                 

                if ((tipoBillete = Console.ReadLine()) == billete500)
                {
                    Console.WriteLine("Indique la cantidad de billetes de $500");
                    cantBilletes500 = cantBilletes500 + 1;
                }
                else 
                {
                    if ((tipoBillete = Console.ReadLine()) == billete200)
                    {
                        Console.WriteLine("Indique la cantidad de billetes de $200");
                        cantBilletes200 = cantBilletes200 + 1;

                    }
                    else 
                    {
                        if ((tipoBillete = Console.ReadLine()) == billete100)
                        {
                            Console.WriteLine("Indique la cantidad de billetes de $100");
                            cantBilletes100 = cantBilletes100 + 1;
                        }
                        else 
                        {
                            if ((tipoBillete = Console.ReadLine()) == billete50)
                            {
                                Console.WriteLine("Indique la cantidad de billetes de $50");

                                cantBilletes50 = cantBilletes50 + 1;
                            }
                            else 
                            {
                                if ((tipoBillete = Console.ReadLine()) == billete20)
                                {
                                    Console.WriteLine("Indique la cantidad de billetes de $20");
                                    cantBilletes20 = cantBilletes20 + 1;
                                }
                                else 
                                {
                                    if ((tipoBillete = Console.ReadLine()) == billete10)
                                    {
                                        Console.WriteLine("Indique la cantidad de billetes de $10");
                                        cantBilletes10 = cantBilletes10 + 1;
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Indique la cantidad de billetes sobrantes");
                                        cantBilletesSobrant = cantBilletesSobrant + 1;

                                    }

                                }
                            }

                        }

                    }
                }
            }

            Console.WriteLine($"Cantidad de billetes ingresados de $1000 : {cantBilletes1000}");
            Console.WriteLine($"Cantidad de billetes ingresados de $500 : {cantBilletes500}");
            Console.WriteLine($"Cantidad de billetes ingresados de $200 : {cantBilletes200}");
            Console.WriteLine($"Cantidad de billetes ingresados de $100 : {cantBilletes100}");
            Console.WriteLine($"Cantidad de billetes ingresados de $50 : {cantBilletes50}");
            Console.WriteLine($"Cantidad de billetes ingresados de $20 : {cantBilletes20}");
            Console.WriteLine($"Cantidad de billetes ingresados de $10 : {cantBilletes10}");
            Console.WriteLine($"Cantidad de billetes sobrantes : {cantBilletesSobrant}");
            //switch (tipoBillete = null)
            //{
            //    case billete1000:
            //        cantBilletes1000 = cantBilletes1000 + 1;

            //        Console.WriteLine("");
            //        break;
            //    case billete500:
            //        Console.WriteLine("");
            //        break;
            //    case billete200:
            //        Console.WriteLine("");
            //        break;
            //    case billete100:
            //        Console.WriteLine("");
            //        break;
            //    case billete50:
            //        Console.WriteLine("");
            //        break;
            //    case billete20:
            //        Console.WriteLine("");
            //        break;
            //    case billete10:
            //        Console.WriteLine("");
            //        break;
            //    default :
            //        Console.WriteLine("");
            //        break;
            //}
        }
    }
}

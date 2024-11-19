using BibliotecaDeProductos;

namespace Testeo_TP
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Creo un estante:
            Estante estante = new Estante(3,1);
            //Creo 4 productos:
            Producto p1 = new Producto("Pepsi", "PESDS74613", (float)18.5);
            Producto p2 = new Producto("Coca-cola","COSDSS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "PESDS74613", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)18.5);

            //Informacion de los productos:
            Console.WriteLine(Producto.MostrarProducto(p1));
            Console.WriteLine(Producto.MostrarProducto(p2));
            Console.WriteLine(Producto.MostrarProducto(p3));
            Console.WriteLine(Producto.MostrarProducto(p4));
            Console.WriteLine("***************************");

            int capMain = 3;
            Estante[] productos = new Estante[capMain];
            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = null;
            }

            //Agrego los productos al estante:
            bool seAgrego = estante + p1;
            if(seAgrego)
            {
                Console.WriteLine($"Agrego {p1.Marca},{(string)p1},{p1.Precio}");
            }
            else 
            {
               Console.WriteLine($"NO grego {p1.Marca},{(string)p1},{p1.Precio}");
            }

            if (estante + p1)
            {
                Console.WriteLine($"Agrego {p1.Marca},{(string)p1},{p1.Precio}");
            }
            else
            {
                Console.WriteLine($"!NO Agrego {p1.Marca},{(string)p1},{p1.Precio}!");
            }

            if (estante + p2)
            {
                Console.WriteLine($"Agrego {p2.Marca},{(string)p2},{p2.Precio}");
            }
            else
            {
                Console.WriteLine($"!NO Agrego {p2.Marca},{(string)p2},{p2.Precio}!");
            }

            if (estante + p3)
            {
                Console.WriteLine($"Agrego {p3.Marca},{(string)p3},{p3.Precio}");
            }
            else
            {
                Console.WriteLine($"!NO Agrego {p3.Marca},{(string)p3},{p3.Precio}!");
            }

            if (estante + p4)
            {
                Console.WriteLine($"Agrego {p4.Marca},{(string)p4},{p4.Precio}");
            }
            else
            {
                Console.WriteLine($"!NO Agrego {p4.Marca},{(string)p4},{p4.Precio}!");
            }

            //Muestro todo el estante:
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine(Estante.MostrarEstante(estante));
            
            estante = estante - p2;

            Console.WriteLine("************************************************");
            Console.WriteLine("Estado del estante luego de eliminar producto 2");
            Console.WriteLine(Estante.MostrarEstante(estante));
        }
    }
}

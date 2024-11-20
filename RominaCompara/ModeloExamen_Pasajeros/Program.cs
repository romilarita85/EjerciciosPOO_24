
//5. En el Main:
//● Crear 3 objetos de la clase “CortaDistancia” con capacidad de 5 pasajeros y
//3 paradas y agregarlos a una lista de Transporte.
//○ Realizar el recorrido de los 3 colectivos con 2 paradas.
//○ Sacar 3 boletos para los 3 colectivos.
//○ Para el colectivo1 realizar el recorrido para la parada que le queda e
//intentar subir un pasajero.
//○ Para el colectivo2 sacar 3 boletos.
//○ Para el colectivo3 sacar 1 boleto.
//● Crear 1 objeto de la clase “LargaDistancia” con capacidad para 5 pasajeros.
//● Crear 6 pasajeros e intentar:
//○ Que los pasajeros 1, 2, 3 y 4 saquen boleto (deberían subir sin
//problemas)
//○ Intentar que el pasajero 2 saque boleto nuevamente (no debería
//dejarlo)
//○ Que el pasajero 5 saque boleto (debería subir sin problema)
//○ Que el pasajero 6 saque boleto (no debería dejarlo)
//● Agregar el transporte de larga distancia a la lista de Transporte.
//● Recorrer la lista y enviar la señal para servir la comida
using BibliotecaDePasajeros_Modelo;

namespace ModeloExamen_Pasajeros
{
    internal class Program
    {
        static void Main(string[] args)
        {//● Crear 3 objetos de la clase “CortaDistancia” con capacidad de 5 pasajeros y
         //3 paradas y agregarlos a una lista de Transporte.

            CortaDistancia colectivo1 = new CortaDistancia(134, 10, "Alberto", 5, 3);
            CortaDistancia colectivo2 = new CortaDistancia(25, 8, "Sandro", 5, 3);
            CortaDistancia colectivo3 = new CortaDistancia(101, 20, "Miguel", 5, 3);
           
            List<Transporte> listaTransporte = new List<Transporte>();
            listaTransporte.Add(colectivo1);
            listaTransporte.Add(colectivo2);
            listaTransporte.Add(colectivo3);

            //○ Realizar el recorrido de los 3 colectivos con 2 paradas.
            colectivo1.RealizarRecorrido(2);
            colectivo2.RealizarRecorrido(2);
            colectivo3.RealizarRecorrido(2);
            Console.WriteLine(colectivo1.CantidadDeParadas);
            Console.WriteLine(colectivo2.CantidadDeParadas);
            Console.WriteLine(colectivo3.CantidadDeParadas);

            //○ Sacar 3 boletos para los 3 colectivos. //ok
            Console.WriteLine(colectivo1.SacarBoleto("Bariloche"));
            Console.WriteLine(colectivo2.SacarBoleto("Las toninas"));
            Console.WriteLine(colectivo3.SacarBoleto("Lobos"));
            Console.WriteLine("------------------------------------------------");
            //○ Para el colectivo1 realizar el recorrido para la parada que le queda e
            //intentar subir un pasajero. //ok
            Console.WriteLine(colectivo1.SacarBoleto("Playa"));
            Console.WriteLine("------------------------------------------------");
            //○ Para el colectivo2 sacar 3 boletos. //ok
            Console.WriteLine(colectivo2.SacarBoleto("Palpala"));
            Console.WriteLine(colectivo2.SacarBoleto("Mar del plata"));
            Console.WriteLine(colectivo2.SacarBoleto("Corrientes"));

            Console.WriteLine("------------------------------------------------");
            //○ Para el colectivo3 sacar 1 boleto. //ok
            Console.WriteLine(colectivo3.SacarBoleto("Tierra del Fuego"));

            Console.WriteLine("------------------------------------------------"); //----Problemas 
            //● Crear 1 objeto de la clase “LargaDistancia” con capacidad para 5 pasajeros.
            List<Pasajero> listaPasajeros = new List<Pasajero>();
            LargaDistancia colectivo4 = new LargaDistancia(33,12,"Roberto", 5, listaPasajeros);
            //● Crear 6 pasajeros e intentar:
            Pasajero p1 = new Pasajero("Juan", "masculino", 32);
            Pasajero p2 = new Pasajero("Roxana", "femenino", 21);
            Pasajero p3 = new Pasajero("Daniela", "femenino", 50);
            Pasajero p4 = new Pasajero("Jonathan", "masculino", 28);
            Pasajero p5 = new Pasajero("Jorge", "masculino", 38);
            Pasajero p6 = new Pasajero("Sabrina", "femenino", 45);

            //○ Que los pasajeros 1, 2, 3 y 4 saquen boleto (deberían subir sin
            //problemas)
            Console.WriteLine(colectivo4.SacarBoleto("Sabana", p1));
            Console.WriteLine(colectivo4.SacarBoleto("Vietma", p2));
            Console.WriteLine(colectivo4.SacarBoleto("Mendoza", p3));
            Console.WriteLine(colectivo4.SacarBoleto("San Juan", p4));

            Console.WriteLine("------------------------------------------------");
            //○ Intentar que el pasajero 2 saque boleto nuevamente (no debería
            //dejarlo)
            Console.WriteLine("Intentar que el pasajero 2 saque boleto nuevamente (no debería dejarlo)\r\n");
            Console.WriteLine(colectivo4.SacarBoleto("Las toninas", p2));
            Console.WriteLine("------------------------------------------------");
            //○ Que el pasajero 5 saque boleto (debería subir sin problema)
            Console.WriteLine("Que el pasajero 5 saque boleto (debería subir sin problema) \r\n");
            Console.WriteLine(colectivo4.SacarBoleto("Parana", p5));
            Console.WriteLine("------------------------------------------------");
            //○ Que el pasajero 6 saque boleto (no debería dejarlo)
            Console.WriteLine(" Que el pasajero 6 saque boleto (no debería dejarlo) \r\n");
            Console.WriteLine(colectivo4.SacarBoleto("San fernando", p6));
            Console.WriteLine("------------------------------------------------");
            //● Agregar el transporte de larga distancia a la lista de Transporte.//ok
            listaTransporte.Add(colectivo4);
          
            //● Recorrer la lista y enviar la señal para servir la comida //ok
            foreach (Transporte transporte in listaTransporte)
            {
                Console.WriteLine(transporte.ServirComida());
            }

            
        }

    }
}

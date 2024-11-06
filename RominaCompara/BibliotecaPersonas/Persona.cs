//Crear la clase Persona, con los siguientes atributos: nombre(string), ciudad(string), edad(entero) y dni(string). 
//Crear un constructor parametrizado y propiedades de lectura/escritura para cada atributo. 
//Crear el método de instancia MostrarPersona, que retorna un string creado a partir de un
//objeto de la clase StringBuilder con los datos de la instancia. 
//En el main, crear 5 personas y agregarlas a una lista. 
//En la clase persona crear un método estático que reciba una lista de personas,
//y permita mostrar cada una de las instancias de la lista.


using System.Text;

namespace BibliotecaPersonas
{
    public class Persona
    {
        string dni;
        string nombre;
        int edad;
        string ciudad;

        public Persona(string dni, string nombre, int edad, string ciudad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
        }

        public string Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }
        public string Ciudad
        {
            get
            {
                return this.ciudad;
            }
            set
            {
                this.ciudad = value;
            }
        }

        public string Mostrar()
        {
            return $"Dni: {this.dni} - Nombre: {this.nombre} - Edad: {this.edad} - Ciudad: {this.ciudad}";
        }
        //En la clase persona crear un método estático que reciba una lista de personas,
        //y permita mostrar cada una de las instancias de la lista.
        public static void MostrarLista(List<Persona>listaPersonas) 
        {
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                Console.WriteLine(listaPersonas[i].MostrarPersona());
            }
 
        }
       
        //Crear el método de instancia MostrarPersona, que retorna un string creado a partir de un
        //objeto de la clase StringBuilder con los datos de la instancia. 
        public string MostrarPersona() 
        {
            StringBuilder sd = new StringBuilder();
            sd.AppendLine($"DNI: {this.dni}");
            sd.AppendLine($"Nombre: {this.Nombre}");
            sd.AppendLine($"Edad: {this.edad}");
            sd.AppendLine($"Ciudad: {this.ciudad}");
            sd.AppendLine("***********************");

            return sd.ToString();
        } 
        
    }
}

//EXAMEN LINTERNA SYSTEM:
//Crea la clase “Linterna” en un proyecto de biblioteca de clases  
//La misma debe tener:
//1.Los atributos marca(string), nivelBateria(int),capacidad(int),estaEncendida(bool),color(Color),nacionalidad(string).
//2.Constructores:
//a-Constructor estatico que inicialice el atributo nacionalidad "CHINA" y la capacidad en 200.
//b-Un constructor q inicialice todos los atributos de instancia
//c-Un constructor q inicialice solo marca y color, estableciendo un valor por defecto de 100 para nivelBateria.
//3.Getters y setters para todos los atributos
//4.Metodo publico LinternaToString(): este metodo de instancia debe retornar un string con toda la informacion de linterna

//5.El metodo privado EncenderApagar():cambia el atributo estaEncendida a true si estaba apagada y a false si estaba encendida

//6.El metodo publico UtilizarLinterna(int minutos): retorna booleano para informar si se pudo encender y se pudo utilizar la cantidad de minutos
//recibidos por parametro.
//Tener en cuenta q para poder encenderse se debe tener bateria y por cada minuto encendida se consume un nivel de la misma.Si la bateria esta en cero, la linterna se debera apagar
//7.El metodo privado RecargarBateria(int nivel): modifica el nivel de bateria de la linterna y es el unico q modifica al atributo nivelBateria.
//Nota:el setter de nivel de bateria debera asegurarse q el nivel seteado no sobrepase la capacidad de la linterna. En caso q este dentro de los
//limites, lo setea de 0 a 200. En caso que sobrepase solo la recargara en su maximo. En caso que el valor sea negativo, la recarga sera 0. Llamar al metodo privado RecargarBateria,
//para asignar el valor definido
//8.En un proyecto de consola, crear un objeto del tipo Linterna y utilizar todos sus metodos.
//
using System.Diagnostics.Metrics;
using System.Drawing;

namespace BibliotecaDeLinternas
{
    public class Linterna
    {
        //ATRIBUTOS
        string marca;
        int nivelBateria;
        static int capacidad;
        bool estaEncendida;
        Color color;
        static string nacionalidad;

        //CONSTRUCTORES:
        //a-Constructor estatico que inicialice el atributo nacionalidad "CHINA" y la capacidad en 200.
        static Linterna()//metodo estatico solo trabaja con metodos estaticos
        {
            Linterna.nacionalidad = "CHINA";
            Linterna.capacidad = 200;
        }
        //b-Un constructor q inicialice todos los atributos de instancia
        public Linterna(string marca, int nivelBateria, bool estaEncendida, Color color)
        {
            this.marca = marca;
            //this.nivelBateria = nivelBateria;
            RecargarBateria(nivelBateria);//cambio el valor a metodo RecargarBateria-
           //le paso el valor establecido de nivel de bateria.Puede poner valores entre 0 y 200
            this.estaEncendida = estaEncendida;
            this.color = color;
        }
       //c-Un constructor q inicialice solo marca y color, estableciendo un valor por defecto de 100 para nivelBateria.
        public Linterna(string marca, Color color)
        {
            this.marca = marca;
            this.color = color;
            this.nivelBateria = 100;//por defecto (no cambia)
        }
        
        //3.Getters y setters para todos los atributos
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        //Nota:el setter de nivel de bateria debera asegurarse q el nivel seteado no sobrepase
        //la capacidad de la linterna. En caso q este dentro de los limites, lo setea de 0 a 200.
        //En caso que sobrepase solo la recargara en su maximo.
        //En caso que el valor sea negativo, la recarga sera 0.
        //Llamar al metodo privado RecargarBateria,para asignar el valor definido
     
        //public void SetNivelBateria(int nivel)
        //{
        //    if (nivel >= 0 && nivel <= 200)
        //    {//En caso q este dentro de los limites, lo setea de 0 a 200.
        //        RecargarBateria(nivel);
        //    }
        //    else //valor negativo o por arriba de 200
        //    {
        //        if (nivel < 0)
        //        {//En caso que el valor sea negativo, la recarga sera 0.
        //            RecargarBateria(0);//el valor minimo q puede tomar es cero
        //        }
        //        else//si no es negativo
        //        { //En caso que sobrepase solo la recargara en su maximo.
        //            RecargarBateria(200); //el valor maximo 
        //        }
        //    }
        //}
        public void SetNivelBateria(int nivel)
        {
            if (nivel >= 0 && nivel <= 200)
            {//En caso q este dentro de los limites, lo setea de 0 a 200.
                this.nivelBateria = nivel;
            }
            else //valor negativo o por arriba de 200
            {
                if (nivel < 0)
                {//En caso que el valor sea negativo, la recarga sera 0.
                    this.nivelBateria = 0;//el valor minimo q puede tomar es cero
                }
                else//si no es negativo
                { //En caso que sobrepase solo la recargara en su maximo.
                    this.nivelBateria = 200; //el valor maximo 
                }
            }
        }
        public static void SetCapacidad(int capacidad) // comportamiento estatico
        {
            Linterna.capacidad = capacidad;
        }
        public void SetEstaEncendidad(bool encendida)
        {
            this.estaEncendida = encendida;
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public static void SetNacionalidad(string nacionalidad)
        {
            Linterna.nacionalidad = nacionalidad;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public int GetNivelBateria()
        {
            return this.nivelBateria;
        }
        public static int GetCapacidad()
        {
            return Linterna.capacidad;
        }
        public bool GetEstaEncendidad()
        {
            return this.estaEncendida;
        }
        public Color GetColor()
        {
            return this.color;
        }
        public static string GetNacionalidad()
        {//SI VOY A HACER UN GET/SET DE UN ATRIBUTO ESTATICO LO TENGO Q HACER ESTATICO
            return Linterna.nacionalidad;
        }
        //4.Metodo publico LinternaToString(): este metodo de instancia debe retornar un string con toda la informacion de linterna
        public string MostrarInfo() 
        {
            return $"Marca: {this.marca} - Niel de bateria:{this.nivelBateria}- Capacidad: {Linterna.capacidad} - Esta encendido:{this.estaEncendida} - color: {this.color.Name} - Nacionalidad: {Linterna.nacionalidad}";
        }
        public string MostrarInfo2() 
        {//para q muestre en estaEncendido si/no en vez de true o false.
            string encendida = "No";
            if (this.estaEncendida)//si this.esta Encendida se cumple(true)
            {
                encendida = "Si";
            }
            return $"Marca: {this.marca} - Niel de bateria:{this.nivelBateria}- Capacidad: {Linterna.capacidad} - Esta encendido:{encendida} - color: {this.color.Name} - Nacionalidad: {Linterna.nacionalidad}";
        }

        //5.El metodo privado EncenderApagar():cambia el atributo estaEncendida a true si estaba apagada y a false si estaba encendida
        private void EncenderApagar1() //solo cambia no retorna nada
        {
            if (this.estaEncendida)//entro el if cuando se cumpla q es true entro
            {//entra a false
                this.estaEncendida = false;
            }
            else 
            {
                this.estaEncendida = true;
            }
        }
        //Otra forma mas simple
        private void EncenderApagar() 
        {
            this.estaEncendida = !this.estaEncendida;
        }

        //6.El metodo publico UtilizarLinterna(int minutos):
        //Retorna booleano para informar si se pudo encender y se pudo utilizar la cantidad de minutos
        //recibidos por parametro.
        //Tener en cuenta q para poder encenderse se debe tener bateria
        // y por cada minuto encendida se consume un nivel de la misma.
        // Si la bateria esta en cero, la linterna se debera apagar
        public bool UtilizarLinterna(int minutos)
        {
            bool ret = false;//NO PUEDO USAR LA LINTERNA
            //Ver si esta encendida y si tiene bateria

            //PUEDO USAR LA LINTERNA: Si tengo nivel de bateria
            if (this.nivelBateria > 0 && this.nivelBateria>=minutos)
            {//puedo utilizar la linterna si la bateria es mayor a cero y menor o igual q la cantidad de minutos
                ret = true;
                
                //-Prender la linterna
                if (this.estaEncendida) // si esta encendida esta en false entro al if
                {
                    EncenderApagar();//prendo la linterna
                }

               //UTILIZAR: por cada minuto encendida se consume un nivel de la misma.
                //this.nivelBateria = this.nivelBateria - minutos;//a la cantidad de bateria q tengo le resto minutos
                int valor = this.nivelBateria - minutos;
                RecargarBateria(valor);//llamamos al metodo recargar y le pasamos el valor

                //VERIFICAR que este o no en cero:"Si la bateria esta en cero, la linterna se debera apagar"
                if (this.nivelBateria == 0)//solo la apago si el nivel esta en cero
                {
                    EncenderApagar();//apago la linterna
                }
            }

            return ret;

        }

        //7.El metodo privado RecargarBateria(int nivel): modifica el nivel de bateria de la linterna y
        //es el unico q modifica al atributo nivelBateria.
        //private void RecargarBateria(int nivel) //es el unico q va a modificar nivelBateria
        //{
        //    this.nivelBateria = nivel;//lo q recibe se lo guarda(set encubierno)
        //}
        private void RecargarBateria(int nivel) //es el unico q va a modificar nivelBateria
        {
            SetNivelBateria(nivel);
        }
    }
}

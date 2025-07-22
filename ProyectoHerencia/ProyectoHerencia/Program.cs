using System;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace ProyectoHerencia
{
    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Perro y llamar a sus métodos
            Perro perro = new Perro("Firulais");
            /*perro.MostrarNombre(); // Mostrar el nombre del perro
            perro.Respirar();      // Método heredado de Mamiferos
            perro.cuidarCrias();   // Método heredado de Mamiferos
            perro.Ladrar();        // Método propio de Perro
            */
            Mamiferos juan = new Perro("Juanito");
            juan.MostrarNombre(); // Mostrar el nombre del perro

            // Crear un objeto de tipo Humano y llamar a sus métodos
            Humano humano = new Humano("Ivan");
            /*humano.MostrarNombre(); // Mostrar el nombre del humano
            humano.Respirar();     // Método heredado de Mamiferos
            humano.cuidarCrias();  // Método heredado de Mamiferos
            humano.Hablar();       // Método propio de Humano
            */
            Mamiferos maria = new Humano("Maria");
            maria.MostrarNombre(); // Mostrar el nombre del humano
            // Crear un objeto de tipo Gorila y llamar a sus métodos
            Gorila gorila = new Gorila("Julio");
            /*gorila.MostrarNombre(); // Mostrar el nombre del gorila
            gorila.Respirar();     // Método heredado de Mamiferos
            gorila.cuidarCrias();  // Método heredado de Mamiferos
            gorila.Trepar();*/       // Método propio de Gorila
            Mamiferos carlos = new Gorila("Carlos");
            carlos.MostrarNombre(); // Mostrar el nombre del gorila

        }
    }

    // Clase base que representa a los mamíferos
    class Mamiferos
    {
        public Mamiferos(String nombre)
        {
            // Constructor de la clase Mamiferos
            nombreSerVivivo = nombre;
        }
        
        // Método que indica que el mamífero respira
        public void Respirar()
        {
            Console.WriteLine("El mamífero respira.");
        }

        // Método que indica que el mamífero cuida a sus crías
        public void cuidarCrias()
        {
            Console.WriteLine("El mamífero cuida a sus crías.");
        }
        public void MostrarNombre()
        {
            Console.WriteLine($"El nombre del ser vivo es: {nombreSerVivivo}");
        }

        private string nombreSerVivivo; // Atributo privado que almacena el nombre del ser vivo

        public virtual void hacerRuido()
        {
            Console.WriteLine("El mamífero hace ruido.");
        }

    }
    // Clase Perro que hereda de Mamiferos
    class Perro : Mamiferos
    {
        public Perro(String nombrePerro) : base(nombrePerro)
        {
            // Constructor de la clase Perro, llama al constructor de Mamiferos
        }
        // Método propio de Perro
        public void Ladrar()
        {
            Console.WriteLine("El perro ladra.");
        }
        public override void hacerRuido()
        {
            Console.WriteLine("El perro hace guau guau.");
        }
    }
    // Clase Humano que hereda de Mamiferos
    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {
        }

        // Método propio de Humano
        public void Hablar()
        {
            Console.WriteLine("El humano habla.");
        }
        public override void hacerRuido()
        {
            Console.WriteLine("El humano habla en su idioma.");
        }
    }
    // Clase Gorila que hereda de Mamiferos
    class Gorila : Mamiferos
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {
        }

        // Método propio de Gorila
        public void Trepar()
        {
            Console.WriteLine("El gorila trepa.");
        }
        public override void hacerRuido()
        {
            Console.WriteLine("El gorila hace grrr grrr.");
        }   
    }
}
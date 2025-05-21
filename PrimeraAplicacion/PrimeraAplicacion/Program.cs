using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto coche
            Coche miCoche = new Coche("Toyota", "Corolla", 2020, 25000);
            
            // Usar métodos del coche
            miCoche.Acelerar(50);
            miCoche.Frenar(20);
            
            // Mostrar información del coche
            miCoche.MostrarInformacion();
            
            // Usar getters y setters
            Console.WriteLine($"Marca actual: {miCoche.Marca}");
            miCoche.Marca = "Honda"; // Cambiar la marca
            Console.WriteLine($"Nueva marca: {miCoche.Marca}");
            
            Console.WriteLine($"Precio actual: {miCoche.Precio}");
            miCoche.Precio = 27000; // Cambiar el precio
            Console.WriteLine($"Nuevo precio: {miCoche.Precio}");
            
            // Intentar establecer un precio negativo (se rechazará)
            miCoche.Precio = -1000;
            Console.WriteLine($"Precio después de intento inválido: {miCoche.Precio}");
        }
    }

    class Coche
    {
        // Campos privados
        private string marca;
        private string modelo;
        private int año;
        private double precio;
        private int velocidadActual;
        
        // Constructor
        public Coche(string marca, string modelo, int año, double precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.precio = precio;
            this.velocidadActual = 0;
        }
        
        // Propiedades (getters y setters)
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        
        public int Año
        {
            get { return año; }
            set { año = value; }
        }
        
        public double Precio
        {
            get { return precio; }
            set 
            { 
                // Validación para evitar precios negativos
                if (value >= 0)
                {
                    precio = value;
                }
                else
                {
                    Console.WriteLine("Error: El precio no puede ser negativo.");
                }
            }
        }
        
        public int VelocidadActual
        {
            get { return velocidadActual; }
            private set { velocidadActual = value; } // Solo se puede modificar internamente
        }
        
        // Métodos
        public void Acelerar(int incremento)
        {
            VelocidadActual += incremento;
            Console.WriteLine($"Acelerando... Velocidad actual: {VelocidadActual} km/h");
        }
        
        public void Frenar(int decremento)
        {
            VelocidadActual = Math.Max(0, VelocidadActual - decremento);
            Console.WriteLine($"Frenando... Velocidad actual: {VelocidadActual} km/h");
        }
        
        public void MostrarInformacion()
        {
            Console.WriteLine($"Información del coche:");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio: {Precio:C}");
            Console.WriteLine($"Velocidad actual: {VelocidadActual} km/h");
        }
    }
}

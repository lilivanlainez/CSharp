// Definimos la interfaz IVehiculo.
// Por convención, los nombres de las interfaces en C# comienzan con una 'I'.
public interface IVehiculo
{
    // La interfaz define los métodos que deben ser implementados.
    // No hay cuerpo de método aquí, solo la firma.
    void Encender();
    void Apagar();
}

// La clase Coche implementa la interfaz IVehiculo.
// Esto obliga a la clase Coche a proporcionar implementaciones para Encender y Apagar.
public class Coche : IVehiculo
{
    // Implementación del método Encender para un Coche.
    public void Encender()
    {
        Console.WriteLine("El coche ha arrancado su motor.");
    }

    // Implementación del método Apagar para un Coche.
    public void Apagar()
    {
        Console.WriteLine("El coche ha apagado su motor.");
    }
}

// La clase Moto también implementa la interfaz IVehiculo.
// Esto nos permite tratar a un Coche y una Moto de la misma manera
// si nos referimos a ellos a través de la interfaz IVehiculo.
public class Moto : IVehiculo
{
    // Implementación del método Encender para una Moto.
    public void Encender()
    {
        Console.WriteLine("La moto se ha encendido.");
    }

    // Implementación del método Apagar para una Moto.
    public void Apagar()
    {
        Console.WriteLine("La moto se ha apagado.");
    }
}

// Ejemplo de uso en el método Main.
class Program
{
    static void Main(string[] args)
    {
        // Creamos una instancia de Coche y la asignamos a una variable de tipo IVehiculo.
        // Esto es polimorfismo en acción.
        IVehiculo miVehiculo = new Coche();
        miVehiculo.Encender(); // Llama a la implementación de Coche.
        miVehiculo.Apagar();   // Llama a la implementación de Coche.

        Console.WriteLine("-------------------");

        // Ahora asignamos una instancia de Moto a la misma variable de tipo IVehiculo.
        miVehiculo = new Moto();
        miVehiculo.Encender(); // Llama a la implementación de Moto.
        miVehiculo.Apagar();   // Llama a la implementación de Moto.
    }
}
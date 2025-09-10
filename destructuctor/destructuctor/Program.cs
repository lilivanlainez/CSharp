public class RecursoDeRed : IDisposable
{
    private bool conectado;

    public RecursoDeRed()
    {
        // Simulamos una conexión a la red
        Console.WriteLine("Conectando a un recurso de red...");
        conectado = true;
    }

    // Destructor
    ~RecursoDeRed()
    {
        // Se llama automáticamente cuando el objeto es recolectado por el GC.
        Console.WriteLine("Destructor: Liberando el recurso de red.");
        if (conectado)
        {
            // Lógica para cerrar la conexión
            conectado = false;
        }
    }

    // Implementación del método Dispose para liberación manual
    public void Dispose()
    {
        Console.WriteLine("Dispose: Liberando el recurso de red manualmente.");
        if (conectado)
        {
            // Lógica para cerrar la conexión
            conectado = false;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // La instancia se crea dentro de un bloque usando 'using' para asegurar la llamada a Dispose
        using (var miRecurso = new RecursoDeRed())
        {
            Console.WriteLine("Usando el recurso de red...");
        } // Dispose se llama automáticamente aquí

        Console.WriteLine("\nEl programa ha terminado. El GC podría llamar al destructor más tarde.");
    }
}
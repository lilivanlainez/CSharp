// Clase genérica que funciona con cualquier tipo <T>
public class Lista<T>
{
    private T[] _elementos;
    private int _contador;

    public Lista()
    {
        _elementos = new T[10];
        _contador = 0;
    }

    public void Agregar(T elemento)
    {
        _elementos[_contador] = elemento;
        _contador++;
    }

    public T Obtener(int indice)
    {
        return _elementos[indice];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creamos una lista genérica para enteros
        Lista<int> listaDeNumeros = new Lista<int>();
        listaDeNumeros.Agregar(10);
        listaDeNumeros.Agregar(20);
        int primerNumero = listaDeNumeros.Obtener(0);
        Console.WriteLine($"Primer número: {primerNumero}");

        // Creamos una lista genérica para cadenas
        Lista<string> listaDeNombres = new Lista<string>();
        listaDeNombres.Agregar("Juan");
        listaDeNombres.Agregar("Maria");
        string primerNombre = listaDeNombres.Obtener(0);
        Console.WriteLine($"Primer nombre: {primerNombre}");
    }
}
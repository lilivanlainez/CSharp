// Clase abstracta 'Figura'
public abstract class Figura
{
    // Propiedad abstracta: debe ser implementada por las clases derivadas
    public abstract double Area { get; }

    // Propiedad no abstracta: con implementación
    public double Perimetro { get; set; }

    // Método abstracto: debe ser implementado por las clases derivadas
    public abstract void Dibujar();

    // Método no abstracto: puede ser usado directamente por las clases derivadas
    public void ImprimirDescripcion()
    {
        Console.WriteLine("Esta es una figura geométrica.");
    }
}

// Clase 'Circulo' que hereda de 'Figura'
public class Circulo : Figura
{
    public double Radio { get; set; }

    // Implementación de la propiedad abstracta 'Area'
    public override double Area
    {
        get { return Math.PI * Radio * Radio; }
    }

    // Implementación del método abstracto 'Dibujar'
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un círculo...");
    }
}

// Clase 'Cuadrado' que hereda de 'Figura'
public class Cuadrado : Figura
{
    public double Lado { get; set; }

    // Implementación de la propiedad abstracta 'Area'
    public override double Area
    {
        get { return Lado * Lado; }
    }

    // Implementación del método abstracto 'Dibujar'
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un cuadrado...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // No se puede crear una instancia de la clase abstracta Figura:
        // Figura miFigura = new Figura(); // Esto causaría un error de compilación

        // Se pueden crear instancias de las clases derivadas
        Circulo miCirculo = new Circulo { Radio = 5 };
        Cuadrado miCuadrado = new Cuadrado { Lado = 4 };

        // Usamos los métodos y propiedades de las clases derivadas
        Console.WriteLine($"Área del círculo: {miCirculo.Area}");
        miCirculo.Dibujar();
        miCirculo.ImprimirDescripcion(); // Usamos el método de la clase base

        Console.WriteLine();

        Console.WriteLine($"Área del cuadrado: {miCuadrado.Area}");
        miCuadrado.Dibujar();
        miCuadrado.ImprimirDescripcion();
    }
}
// Definición del enum
public enum DiasDeLaSemana
{
    Lunes,
    Martes,
    Miercoles,
    Jueves,
    Viernes,
    Sabado,
    Domingo
}

public class Program
{
    public static void Main(string[] args)
    {
        // Declaramos una variable de tipo enum
        DiasDeLaSemana diaActual = DiasDeLaSemana.Miercoles;

        // Usamos el enum para una comparación
        if (diaActual == DiasDeLaSemana.Miercoles)
        {
            Console.WriteLine("¡Hoy es mitad de semana!");
        }

        // Puedes convertir un enum a su valor entero subyacente
        int valorNumerico = (int)diaActual;
        Console.WriteLine($"El valor numérico de Miercoles es: {valorNumerico}"); // El resultado será 2, ya que por defecto comienza en 0

        // También puedes asignar valores explícitos a los miembros del enum
        // public enum CodigosDeError
        // {
        //     Exito = 0,
        //     ErrorDeConexion = 101,
        //     ErrorDeAutenticacion = 102
        // }
    }
}
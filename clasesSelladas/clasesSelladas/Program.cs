// Clase sellada
public sealed class TarjetaDeCredito
{
    public string Numero { get; set; }
    public string FechaExpiracion { get; set; }
    public int CodigoCVV { get; set; }

    public void RealizarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de ${monto} con la tarjeta {Numero}.");
        // Lógica de procesamiento de pago
    }
}

// Esto causaría un error de compilación
// public class TarjetaDeCreditoConDescuento : TarjetaDeCredito
// {
//     public void AplicarDescuento()
//     {
//         Console.WriteLine("Aplicando descuento al pago.");
//     }
// }

public class Program
{
    public static void Main(string[] args)
    {
        // Puedes crear una instancia de la clase sellada
        TarjetaDeCredito miTarjeta = new TarjetaDeCredito
        {
            Numero = "1234-5678-9012-3456",
            FechaExpiracion = "12/25",
            CodigoCVV = 123
        };

        miTarjeta.RealizarPago(150.75m);
    }
}
namespace lambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperacionesMatematicas operacion= new OperacionesMatematicas(num => num*num);
            Console.WriteLine(operacion(4));
            
        }
       /*public static int Cuadrado(int n)
        {
            return n*n;
        }*/
    }
    public delegate int OperacionesMatematicas(int n);
    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
    }
}

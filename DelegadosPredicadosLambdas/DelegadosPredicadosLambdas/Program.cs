namespace DelegadosPredicadosLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creacion del objeto delegado
            ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            ElDelegado("Ivan");

            ElDelegado= new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            ElDelegado("Ivan");
        }
        //definicion del objeto delegado
        delegate void ObjetoDelegado(string msj);
    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine($"Hola {msj} acabo de llegar, que tal?");
        }
    }
    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine($"Hola ya me marcho, Ccuidate mucho {msj}");
        }
    }
}

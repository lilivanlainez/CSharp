using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 8;
            numeros[2] = 9;
            numeros[3] = 10;

            ProcesaDatos(numeros);
        }
        static void ProcesaDatos(int[] datos)
        {
            foreach (int dato in datos)
            {
                Console.WriteLine(dato);

            }

            for (int i = 0;i < datos.Length; i++)
            {
                datos[i] += 10;
                Console.WriteLine(datos[i]);
            }

        }

            
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//estamos aprendiendo a programar en  C#
namespace PrimeraAplicacion
{
    class Program
    {

        static void Main(string[] args)
        {
            int z = 0;

            while (z < 10)
            {
                Console.WriteLine($"el numero de vuelta es: {z}");
                z++;
            }
            int a = 0;
            Console.WriteLine("DO WHILE");
            do
            {
                Console.WriteLine($"El numero de vuelta es: {a}");
            } while (a == 10);

                Console.WriteLine();
            
            

        }

       
    }
}

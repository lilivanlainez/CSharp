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
            Console.WriteLine(restaNumeros(5,6));
            
            void mensajeEnPantalla()
            {
                Console.WriteLine("Mensaje desde el metodo");
            }
            int sumaNumeros()
            {
                int num1 = 7;
                int num2 = 7;

                int resultado = num1 + num2;
                return resultado;
            }

            Console.WriteLine(sumaNumeros());
            mensajeEnPantalla();

            



        }
        private static int restaNumeros(int num1, int num2)
        {
            return num2 - num1;
        }

    }
}

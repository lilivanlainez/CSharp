using System;
using System.CodeDom;
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
            Random rnd = new Random();
            int aleatorio = rnd.Next(0, 100);
            int minumero;
            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");
            try
            {
                do
                {
                    intentos++;
                    minumero = int.Parse(Console.ReadLine());
                    if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");
                    if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");
                } while (aleatorio != minumero);
                Console.WriteLine($" Correcto! Hasnecesitado {intentos} intentos");
            }
            catch (Exception)
            {
                Console.WriteLine("No has introducido el valor correcto");
            
            }



        }

       
    }
}

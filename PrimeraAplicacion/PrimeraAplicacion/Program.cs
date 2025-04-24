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

            int a=0;

            while (a <30)
            {
                Console.WriteLine("El numero es: "+ a);
                a++;
            }
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(0,100);

            while(numeroAleatorio != 50)
            {
                Console.WriteLine(numeroAleatorio);
               
                numeroAleatorio = rnd.Next(0,100);
            }
            
            

        }

       
    }
}

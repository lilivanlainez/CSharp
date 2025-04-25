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
            Console.WriteLine("Escribe la hora");

            int hora = int.Parse(Console.ReadLine());

            switch (hora)
            {
                case int n when n<12:
                    Console.WriteLine("Buenos dias");
                    break;
                case int n when n > 12 && n <18:
                    Console.WriteLine("Buenas Tardes");
                    break;
                case int n when n > 18 && n < 24:
                    Console.WriteLine("Buenas noches");
                    break;
                default:
                    Console.WriteLine("No se que horas son");
                    break;
            }
            

        }

       
    }
}

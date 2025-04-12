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
            
            const double PI = 3.1416;

            
            double radio = double.Parse(Console.ReadLine());
            double area = radio * radio * PI;
            Console.WriteLine($"El area del circulo es: {area}");


        }
    }
}

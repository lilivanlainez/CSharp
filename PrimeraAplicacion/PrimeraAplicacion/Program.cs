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
            Console.WriteLine(suma(2,44));    
        }

        private static int suma(int num1, int num2) => num1 + num2;
    }
}

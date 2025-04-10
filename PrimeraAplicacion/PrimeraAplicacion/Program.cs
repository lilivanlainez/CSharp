using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//estamos aprendiendo a programar en  C#
namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona1);

            var edadPersona = 34;

            Console.WriteLine(edadPersona);

            var miNombre = "Nelson Ivan Colorado Lainez";
            Console.WriteLine(miNombre);

            double temperatura = 30.4;
            Console.WriteLine(temperatura);
            int temperaturaMadrid;

            temperaturaMadrid =(int) temperatura;
            Console.WriteLine(temperaturaMadrid);

            int habitantesCiudades = 1000;
            long habitantesCiudad2018 = habitantesCiudades;


        }
    }
}

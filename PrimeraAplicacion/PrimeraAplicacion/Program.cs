﻿using System;
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
            int edad;
            string carnet;
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            Console.WriteLine("Introduce tu edad");
            edad = Int32.Parse(Console.ReadLine());

            if(edad >= 18)
            {
                Console.WriteLine("Adelante puedes pasar porque eres mayor de edad");
                Console.WriteLine("Tienes Licencia de conducir?");
                carnet = Console.ReadLine();
                if (edad >= 18 && carnet == "si")
                {
                    Console.WriteLine("Puedes conducir");
                }
                else
                {
                    Console.WriteLine("Lo  siento, no puedes conducir");
                }
            }
            else
            {
                Console.WriteLine("No puedes pasar, regresa cuando seas mayor de edad");
            }

            
            

        }

       
    }
}

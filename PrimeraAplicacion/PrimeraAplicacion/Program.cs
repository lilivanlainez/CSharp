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
            Circulo calculo = new Circulo();
            double circuloUno = calculo.calculoArea(12);

            Console.WriteLine(circuloUno);

        }

       
    }
    class Circulo
    {
        private double pi = Math.PI; //propiedad de la clase circulo o campos de clase

        public double calculoArea(int radio) {  return pi * radio; }

        
    }
}

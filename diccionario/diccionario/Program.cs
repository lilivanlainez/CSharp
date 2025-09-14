using System;
using System.Collections.Generic;

namespace diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();
            //rellenar el diccionario

            edades.Add("Juan", 18);
            edades.Add("Diandra", 35);
            edades["Maria"] = 25;
            //recorrer el diccionario
            foreach (KeyValuePair<string, int> kvp in edades)
            {
                Console.WriteLine("metodo utilizando foreach sin sugerencia de microsoft");
                Console.WriteLine("Nombre: " + kvp.Key + " " + kvp.Value);
                Console.WriteLine("metodo utilizando foreach con sugerencia de microsoft");
                Console.WriteLine("Nombre {0} Edad: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
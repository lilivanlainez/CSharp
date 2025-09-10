using System;
using System.Collections.Generic;

namespace colas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            //rellenado o agregado de elementos a la cola

            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                numeros.Enqueue(numero);
            }
            //recolliendo la cola

            Console.WriteLine("Recorriendo el Queue");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            //eliminando elementos del Queue
            Console.WriteLine("Eliminando elementos del Queue");
            numeros.Dequeue();
            
        }
    }
}

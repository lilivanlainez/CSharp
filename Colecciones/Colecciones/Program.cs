using System;
namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
    

            Console.WriteLine("Cuantos elementos quieres introducir?");
           
            int elem = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine("Introduce el elemento: " + (i+1));
                list.Add(Int32.Parse(Console.ReadLine()));
            }
            Console.WriteLine("La cantidad de elementos son: " + elem);
            Console.WriteLine("y son los siguientes: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list[{i}]: ");
                Console.WriteLine(list[i]);
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
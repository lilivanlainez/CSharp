using System;
using System.Collections.Generic;

namespace StackColection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int numero in new int[5] { 2, 4, 6, 8, 10 })
            {
                stack.Push(numero);
            }
            //recorriendo el stack
            Console.WriteLine("Recorriendo el Stack");
            foreach (int numero in stack)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            foreach (int item in new int[] {10,8,6,4,2,0})
            {
                list.AddFirst(item);
            }

            //Los dos siguientes codigos hacen exactamente lo mismo
            /*
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }*/
            for(LinkedListNode<int> nodo=list.First; nodo!=null; nodo=nodo.Next)
            {
                int item = nodo.Value;
                Console.WriteLine(item);
            }
        }
    }
}
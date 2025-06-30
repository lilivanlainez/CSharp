using System;

namespace UsoArrays
{
    class UsoArryas
    {
        static void Main(string[] args)
        {
            int[] edades;

            edades = new int[4];

            edades[0] = 1;
            edades[1] = 2;
            edades[2] = 3;
            edades[3] = 4;

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine(edades[i]);
            }

            int[] edades2 = {23,4,5,6,7};

            for (int i = 0;i < edades2.Length; i++)
            {
                Console.WriteLine(edades2[i]);

                int[] edades3 = { };
              
            }
        }
    }
}
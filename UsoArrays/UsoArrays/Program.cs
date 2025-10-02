using System;

namespace UsoArrays
{
    class UsoArryas
    {
        static void Main(string[] args)
        {
            smartPhone[] phone = new smartPhone[7];

            for (int i = 0; i < phone.Length; i++)
            {
                
                phone[i] = new smartPhone($"Motorola{i}",$"Moto{i}", 128, 8);
            }
            for (int i = 0; i < phone.Length; i++)
            {
                Console.WriteLine(phone[i]);
            }
            /*
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
            */

            //array implisitos
            var datos = new[] { "Nelson", "Ivan", "Colorado" };

            foreach (var item in datos)
            {
                Console.WriteLine(item);
            }

            Empleados Ana = new Empleados("Ana", 27);

            //Array de objetos
            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = Ana;

            //array anonimos
            var personas = new[]
            {
                new{Nombre="Ivan", edad=34},
                new{Nombre="Nelson", edad = 34},
                new{Nombre="Colorado", edad=34}
            };

        }
        class Empleados
        {
            public Empleados(String nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
            public String nombre { get; set; }
            private int edad { get; set; }
        }

        public class smartPhone
        {
            public smartPhone(String marca, String modelo, int almacenamiento, int ram)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.ram = ram;
            }
            private String marca { get; set; }
            private String modelo { get; set; }
            private int ram { get; set; }

        }

        
    }
}
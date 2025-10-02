using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");
            Juan.SALARIO = 1200;
            Console.WriteLine("El salario del empleado es: " + Juan.SALARIO);
        }

        class Empleado
        {
            public Empleado(string name)
            {
                this.nombre = name;
            }
            /*
            public void setSalario(double salario)
            {
                if (salario < 0)
                {
                    Console.WriteLine("El salario no puede ser negativo, se asignara 0 como salario");
                    this.salario = salario;
                }
                else
                {
                    this.salario = salario;
                }
            }
            public double getSalario()
            {
                return salario;
            }
            */
            private double evaluaSalario(double salario)
            {
                if(salario < 0) return 0;
                else return salario;
            }

            //creacion de propiedad

            public double SALARIO
            {
                get { return this.salario;}
                set { this.salario = evaluaSalario(value); }
            }
            private double salario;
            private string nombre;
        }
    }
}
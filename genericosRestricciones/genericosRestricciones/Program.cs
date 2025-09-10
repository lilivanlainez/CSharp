using System;
using System.Runtime.CompilerServices;

namespace genericosRestricciones
{
    class program
    {
        static void Main(string[] args)
        {
            AlmacenaEmpleados<Director> empleados0= new AlmacenaEmpleados<Director> (3);

            empleados0.agregar(new Director(4500));
            empleados0.agregar(new Director(1500));
            empleados0.agregar(new Director(2500));

            AlmacenaEmpleados<Estudiante> empleados1 = new AlmacenaEmpleados<Estudiante>(3);

            empleados1.agregar(new Estudiante(4500));
            empleados1.agregar(new Estudiante(1500));
            empleados1.agregar(new Estudiante(2500));
        }
    }

    class AlmacenaEmpleados<T> where T : IParaEmpleados
    {
        public AlmacenaEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }
        public void agregar( T obj)
        {
            datosEmpleado[0] = obj;
            i++;
        }
        public T getEmpleado(int i)
        {
            return datosEmpleado[i];
        }
        private int i = 0;
        private T[] datosEmpleado;
    }
    class Director : IParaEmpleados
    {
        public Director(double salario)
        {
            this.salario =salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }
    class Secretaria : IParaEmpleados 
    {
        public Secretaria(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }
    class Electricista : IParaEmpleados 
    {
        public Electricista(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }
    class Profesor : IParaEmpleados
    {
        public Profesor(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double getSalario()
        {
            return salario;
        }
    }
    class Estudiante
    {
       public Estudiante(double edad)
        {
            this.edad= edad;
        }
        private double edad;
    }
    interface IParaEmpleados
    {
        double getSalario();
    }
}

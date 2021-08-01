using System;

namespace AlmacenEmpleadosT
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Secretaria> almacenEmpleados = new AlmacenEmpleados<Secretaria>(3);
            almacenEmpleados.setEmpleado(new Secretaria(4500));
            almacenEmpleados.setEmpleado(new Secretaria(1500));
            almacenEmpleados.setEmpleado(new Secretaria(2500));

            for(int i =0; i < almacenEmpleados.CONTADOR; i++)
            {
                Console.WriteLine(almacenEmpleados.getEmpleado(i).getSalario());
            }
        }
    }
    class AlmacenEmpleados<T> where T:IParaEmpleados
    {
        private int contador = 0;
        private T[] ts;
        public AlmacenEmpleados(int x)
        {
            this.ts = new T[x];
        }
        public void setEmpleado(T ts)
        {
            this.ts[contador] = ts;
            contador++;
        }
        public T getEmpleado(int elemento)
        {
            return ts[elemento];
        }
        public int CONTADOR
        {
            get => contador;
        }
    }
    class Estudiante
    {
        private double edad;
        public Estudiante(double edad)
        {
            this.edad = edad;
        }
        public double getEdad()
        {
            return edad;
        }
    }
    interface IParaEmpleados
    {
        double getSalario();
    }
    class Secretaria : IParaEmpleados
    {
        private double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
    class Profesor : IParaEmpleados
    {
        private double salario;
        public Profesor(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
    class Director : IParaEmpleados
    {
        private double salario;
        public Director(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
    class Electricista : IParaEmpleados
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }
    }
}

using System;

namespace PropiedadesAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Juan");
           empleado.SALARIO = 750;
           // empleado.SALARIO += 500;
           System.Console.WriteLine("El salario del empleado es: " + empleado.SALARIO);
        }
    }
    class Empleado
    {
        private string _nombre;
        private double _salario;
        public Empleado(string nombre)
        {
            this._nombre = nombre;
        }

        private double evaluaSalario(double salario){
            if (salario < 0)
            {
                return 0;
            }
            else
            {
                return salario;
            }
        }
        public double SALARIO {
            get => this._salario;
            set => this._salario = evaluaSalario(value);
        }
        // Creando propiedad
        /* public double SALARIO{
            get {return this.salario;}
            set {this.salario = evaluaSalario(value);}
        }

        /* public void setSalario(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("Viva el capitalismo, pero salario menor que 0 es malo. Usando 0");
                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }
        public double getSalario()
        {
            return salario;
        } */
    }
}

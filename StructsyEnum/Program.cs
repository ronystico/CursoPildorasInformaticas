using System;

namespace StructsyEnum
{
    enum Bonus
    {
        bajo = 500, normal = 1000, bueno = 1500, extra = 3000
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Empleado empleado = new Empleado(1200, 250);
            // empleado.cambiaSalario(empleado, 100);
            // Console.WriteLine(empleado);

            //Bonus bonus = Bonus.bajo;
            //double bonus1 = (double)bonus;
            //double bonus2 = 1500 + bonus1;
            //Console.WriteLine(bonus2);

            Empleado empleado = new Empleado(Bonus.extra, 1900.50);
            Console.WriteLine("El salario del empleado es: " + empleado.SALARIO);
        }
    }
    class Empleado
    {
        private double salario;
        private Bonus bonus;
        public Empleado(Bonus bonus,double salario)
        {
            this.bonus = bonus;
            this.salario = salario;
        }
        public double SALARIO { get => salario + (double)bonus;}
    }

    //public struct Empleado
    //{
    //    public double salarioBase, comision;
    //    public Empleado(int salarioBase, int comision)
    //{
    //        this.salarioBase = salarioBase;
    //        this.comision = comision;
    //}
    //    public override string ToString()
    //    {
    //        return string.Format("Salario y comisión del empleado ({0},{1})", this.salarioBase, this.comision);
    //    }
    //    public void cambiaSalario(Empleado emp,double incremento)
    //    {
    //        emp.salarioBase += incremento;
    //        emp.comision += incremento;
    //    }
    //}
}

using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<DateTime> almacenObjetos = new AlmacenObjetos<DateTime>(4);
            //almacenObjetos.agregar("Juan");
            //almacenObjetos.agregar("Elena");
            //almacenObjetos.agregar("Antonio");
            //almacenObjetos.agregar("Sandra");

            almacenObjetos.agregar(new DateTime());
            almacenObjetos.agregar(new DateTime());
            almacenObjetos.agregar(new DateTime());
            almacenObjetos.agregar(new DateTime());

            //almacenObjetos.agregar(new Empleado(1500));
            //almacenObjetos.agregar(new Empleado(2500));
            //almacenObjetos.agregar(new Empleado(3500));
            //almacenObjetos.agregar(new Empleado(4500));

            DateTime nombrePersona = almacenObjetos.getElemento(2);
            Console.WriteLine(nombrePersona);
        }
    }
    class AlmacenObjetos<T>
    {
        private T[] datosElemento;
        private int i = 0;
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }
        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        public T getElemento(int i) { 
            return datosElemento[i];
        }
    }
    class Empleado
    {
        private double salario;
        public Empleado(double salario)
        {
            this.salario = salario;
        }
        public double getSalario()
        {
            return salario;
        }
    }
}

using System;

namespace ClaseAnonima
{
    class Program
    {
        static void Main(string[] args)
        {
            //var anonimo = new
            //{
            //    altura = 1,
            //    ancho = 1,
            //    loco = "otro loco"
            //};

            //int[] edades;
            //edades = new int[4];
            //edades[0] = 15;
            //edades[1] = 27;
            //edades[2] = 19;
            //edades[3] = 80;

            //int[] edades = new int[5] { 15, 27, 19, 80, 21 };

            //Console.WriteLine(edades[4]);

            // var klk = new[] { "Juan", "Díaz", 15 };
            // Array implícito
            var valores = new[] { 15, 28, 35, 75.5, 30.30 };
            // array de objetos
            Empleados[] arrayEmpleados = new Empleados[2];
            arrayEmpleados[0] = new Empleados("Sara",37);
            Empleados Ana = new Empleados("Ana", 27);
            arrayEmpleados[1] = Ana;
            // array anónimo
            var personas = new[]
            {
                new{Nombre = "Juan", Edad = 19 },
                new {Nombre = "maría", Edad=49 },
                new {Nombre= "Diana",Edad=35 }
            };
            for(int i =0;i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i]);
            }
            
            foreach(var varr in personas)
            {
                Console.WriteLine(varr);
            }
        }
    }
    class Empleados
    {
        String nombre;
        int edad;
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}

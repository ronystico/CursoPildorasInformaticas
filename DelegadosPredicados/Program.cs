using System;
using System.Collections.Generic;

namespace DelegadosPredicados
{
    class Program
    {
        //static bool DamePares(int num)
        //{
        //    if (num % 2 == 0) return true;
        //    else return false;
        //}

        static bool Existe(Personas personas)
        {
            if (personas.Edad >= 18) return true;
            else return false;
        }
        static void Main(string[] args)
        {

            Ejercicio.CalcularPrimo();

            ///////////////////////////////////////////////
            //List<Personas> personas = new List<Personas>();

            //Personas personas1 = new Personas();
            //personas1.Nombre = "Juana";
            //personas1.Edad = 8;            
            //Personas personas2 = new Personas();
            //personas2.Nombre = "María";
            //personas2.Edad = 7;
            //Personas personas3 = new Personas();
            //personas3.Nombre = "Ana";
            //personas3.Edad = 3;

            //personas.AddRange(new Personas[] { personas1, personas2, personas3 });

            //Predicate<Personas> predicate = new Predicate<Personas>(Existe);
            //bool existe = personas.Exists(predicate);

            //if (existe)
            //{
            //    Console.WriteLine("Hay mayores de edad");
            //}
            //else
            //{
            //    Console.WriteLine("No hay mayores de edad");
            //}

            ////////////////////////////////////////////////////////

            //List<int> list = new List<int>();
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //// Declaramos delegado predicado
            //Predicate<int> predicate = new Predicate<int>(DamePares);
            //List<int> numPares = list.FindAll(predicate);
            //foreach (int num in numPares)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}

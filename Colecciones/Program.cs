using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Introduce elementos en la colección (0 para salir)");
            int elem = 1;
            while(elem != 0)
            {
                elem = int.Parse(Console.ReadLine());
                numeros.Add(elem);
            }
            numeros.RemoveAt(numeros.Count - 1);
            Console.WriteLine("Elementos introducidos");
            foreach(int lol in numeros)
            {
                Console.WriteLine(lol);
            }
            //Console.WriteLine("Cuántos elementos quieres");

            //int elem = int.Parse(Console.ReadLine());
            //for(int i = 0; i < elem; i++)
            //{
            //    numeros.Add(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("Elementos introducidos");
            //for (int i = 0; i < numeros.Count; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

            //for(int i = 0; i < listaNumeros.Length; i++)
            //{
            //    numeros.Add(listaNumeros[i]);
            //}

            //for(int i =0; i<listaNumeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

        }
    }
}

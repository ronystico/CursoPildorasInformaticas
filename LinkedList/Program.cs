using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Ivamn
    {
        string coso1, coso2;
        public Ivamn(string coso1,string coso2)
        {
            this.coso1 = coso1;
            this.coso2 = coso2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<String, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs.Add("Juan", 18);
            keyValuePairs.Add("Diandra", 35);
            keyValuePairs["Maria"] = 25;
            keyValuePairs["Antonio"] = 29;

            foreach(KeyValuePair<string,int> keyValuePair in keyValuePairs)
            {
                Console.WriteLine("Nombre: {0} / Edad: {1}",keyValuePair.Key,keyValuePair.Value);
            }

            //Stack<int> numeros = new Stack<int>();
            //// Rellenando o agregando elementos a la cola
            //foreach(int numero in new int[5] { 2, 4, 6, 8, 10 })
            //{
            //    numeros.Push(numero);
            //}
            //// Recorriendo la cola
            //Console.WriteLine("Recorriendo el stack pila (no queue)");
            //foreach(int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //// eliminando elementos del kiwi (queue)
            //numeros.Pop();
            //Console.WriteLine("Eliminando elementos");
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            //Queue<int> klk = new Queue<int>(numeros.ToArray());
            //Console.WriteLine(242343);
            //foreach (int numero in klk)
            //{
            //    Console.WriteLine(numero);
            //}

            ////////////////////////////////////////

            //LinkedList<int> list = new LinkedList<int>();
            //foreach(int numeros in new int[] { 10, 8, 6, 4, 2, 0 })
            //{
            //    list.AddLast(numeros);
            //}
            //// list.Remove(6);
            //LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);
            //list.AddFirst(nodoImportante);
            ////foreach(int numeros in list)
            ////{
            ////    Console.WriteLine(numeros);
            ////}
            //for(LinkedListNode<int> nodo = list.First; nodo != null; nodo = nodo.Next)
            //{
            //    int numero = nodo.Value;
            //    Console.WriteLine(numero);
            //}
        }
    }
}

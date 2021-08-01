using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicados
{
    class Ejercicio
    {
        // Delegado que devuelva numeros primos
        static bool EsPrimo(int numero)
        {
            for(int i = 0; i < numero; i++) if (numero % 2 == 0) return false;
            return true;
        }
        public static void CalcularPrimo()
        {
            Predicate<int> predicatePrimo = new Predicate<int>(EsPrimo);

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 2, 3, 5, 6, 7, 76, 4 });

            if (numeros.Exists(predicatePrimo)) {
                Console.WriteLine("Hay al menos un número primo");
                List<int> numerosprimos = numeros.FindAll(predicatePrimo);
                foreach (int lol in numerosprimos)
                {
                    Console.WriteLine(lol);
                }
            } 
            else Console.WriteLine("No hay un primo");
        }
    }
}

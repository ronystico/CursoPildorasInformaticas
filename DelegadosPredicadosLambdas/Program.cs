using System;

namespace DelegadosPredicadosLambdas
{
    class Program
    {
        // Definicion del objeto delegado
        delegate void ObjetoDelegado(string msjj);
        static void Main(string[] args)
        {
            ObjetoDelegado objetoDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            objetoDelegado("Hola tú");
            objetoDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            objetoDelegado("Adiós tú");
        }
    }
    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine("Mensaje de bienvenida: {0}", msj);
        }
    }
    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine("Mensaje de despedida: {0}", msj);
        }
    }
}

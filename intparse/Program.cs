using System;

namespace intparse
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertirEuroDolar klk = new ConvertirEuroDolar();
            klk.CambiarValorEuro(-7.85);
            Console.WriteLine(klk.Convertir(50));

        }
    }
    class Circulo
    {
        private const double pi = 3.1416; // campo de clase
        
        public double CalculoArea(int radio)
        {
            return pi * radio * radio;
        }
    }
    class ConvertirEuroDolar
    {
        private double euro = 1.253;
        public double Convertir(double cantidad)
        {
            return cantidad * euro;
        }
        public void CambiarValorEuro (double nuevoValor)
        {
            if (nuevoValor > 0)
            {
                euro = nuevoValor;
            }
            
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Mi web es: https://pildorasinformaticas.es";
            Regex regex = new Regex("https?://(www.)?pildorasinformaticas.es");

            MatchCollection matchCollection = regex.Matches(texto);

            if(matchCollection.Count > 0) Console.WriteLine("Hallada web");
            else Console.WriteLine("Nope");
        }
    }
}

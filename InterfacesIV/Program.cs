using System;

namespace InterfacesIV
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosVarios avisosVarios = new AvisosVarios();
            AvisosVarios avisosVarios1 = new AvisosVarios("Jefatura Provincial Madrid","Sanción de velocidad: 300 $", "02-05-19");

            avisosVarios.MostrarAviso();

            Console.WriteLine(avisosVarios1.getFecha());
            avisosVarios1.MostrarAviso();
        }
    }
}

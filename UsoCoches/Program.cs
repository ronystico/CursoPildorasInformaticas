using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche();
            coche.setExtras(true, "cuero");
            Console.WriteLine(coche.getExtras());

            Thread lol = new Thread(Contar1);
            Thread lol2 = new Thread(Contar2);
            lol.Start();
            lol2.Start();
            Console.ReadKey();

            int fabianTonto =1 ;
            switch (fabianTonto)
            {
                case 1: Console.WriteLine("fabian tonto"); break;
                case 2: Console.WriteLine(); break;
                case 3: Console.WriteLine(); break;
            }

            MetodoPunto();
            Console.WriteLine($"Número de objetos creados: {Punto.ContarObjetos()}");
            Console.WriteLine(Math.PI);
        }
        public static void MetodoPunto()
        {
            Punto punto = new Punto(128, 80);
            Punto punto1 = new Punto();
            Punto punto2 = new Punto();

            double distancia = punto1.CalcularDistancia(punto);
            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
        }
        public static void Contar1()
        {
            for(int i =1;i<11;i++)
            {
                Console.WriteLine($"Método 1 {i}");
                Thread.Sleep(1000);
            }
        }
        public static void Contar2()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Método 2 {i}");
                Thread.Sleep(2000);
            }
        }
    }
    class Coche
    {
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            climatizador = true;
            tapiceria = "tela";
        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;

        }

        public int getRuedas()
        {
            return ruedas;
        }

        public string getInfoCoche()
        {
            return "Información el coche:" + "\n Ruedas: " +
                 ruedas + "\n Largo: " + largo + "\n Ancho: " + ancho;
        }

        public void setExtras(bool paramClimatizador, String paramTapiceria)
        {
            climatizador = paramClimatizador;
            tapiceria = paramTapiceria;
            
        }

        public String getExtras()
        {
            return "Extras del coche: \n" + "Tapicería: " + tapiceria + " Climatizador: " + climatizador;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;

        
    }
}

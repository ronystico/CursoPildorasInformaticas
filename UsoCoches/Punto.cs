using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCoches
{
    class Punto
    {
        private int x, y;
        private static int contadorDeObjetos = 0;
        private int Lol { get; set; }
        private int k = 0;
        public Punto(int x, int y)
        {
            Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }
        public double CalcularDistancia(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distanciaPuntos;
        }
        public static int ContarObjetos() => contadorDeObjetos;
    }
}

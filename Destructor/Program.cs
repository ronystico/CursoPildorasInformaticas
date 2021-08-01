using System;
using System.IO;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos manejoArchivos = new ManejoArchivos();
            manejoArchivos.mensaje();
        }
    }
    class ManejoArchivos
    {
        StreamReader streamReader = null;
        int contador = 0;
        string linea;

        public ManejoArchivos()
        {
            streamReader = new StreamReader(@"c:\klk.txt");
            while((linea = streamReader.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        public void mensaje()
        {
            Console.WriteLine("hay {0} líneas", contador);
        }
        ~ManejoArchivos()
        {
            streamReader.Close();
        }
    }

}

using System;

namespace HerenciaSuperclaseObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caballo micaballo = new Caballo("Babieca");
            //Humano mihumano = new Humano("Juan");
            //Gorila migorila = new Gorila("Copito");

            //Mamiferos[] mamifero = new Mamiferos[3];
            //mamifero[0] = micaballo; // mamiferos
            //mamifero[1] = mihumano; // override
            //mamifero[2] = migorila; // override

            //for (int i = 0; i < mamifero.Length; i++) {
            //    mamifero[i].Pensar();
            //}

            //Mamiferos animal = new Mamiferos("Bucéfalo");
            //Caballo persona = new Caballo("Juan");
            //animal = persona;

            //mihumano.getNombre();
            //micaballo.getNombre();
            //migorila.getNombre();

            //Ballena ballena = new Ballena("Wally");
            //ballena.Nadar();

            //ISaltoConPatas Imicaballo = micaballo;

            //System.Console.WriteLine("Patas para saltar de Babieca: " + Imicaballo.NumeroPatas());

            Lagartija lagartija = new Lagartija("Juancho");
            lagartija.getNombre();

            Humano humano = new Humano("Juan");
            humano.getNombre();

        }
    }
    interface IAnimalesYDeportes
    {
        string TipoDeporte();
        bool EsOlimpico();

    }
    interface IMamiferosTerrestres {
        int NumeroPatas();
    }
    interface ISaltoConPatas
    {
        int NumeroPatas();
    }
    abstract class Animales{
        public void Respirar(){
            Console.WriteLine("Soy capaz de respirar");
        }
        public abstract void getNombre();
    }
    class Lagartija : Animales
    {
        private string nombreReptil;
        public Lagartija(String nombre)
        {
            nombreReptil = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine($"El nombre del reptil es {nombreReptil}");
        }
    }
    class Mamiferos : Animales
    {
        private String nombreSerVivo;
        public Mamiferos(String nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }
        public virtual void Pensar()
        {
            Console.WriteLine("pensamiento básico instintivo");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías");
        }
        public override void getNombre()
        {
            Console.WriteLine($"El nombre del mamífero es {nombreSerVivo}");
        }
    }
    class Ballena : Mamiferos {
        public Ballena(String nombreBallena):base(nombreBallena){

        }
        public void Nadar(){
            System.Console.WriteLine("Soy capaz de nadar");
        }
    }
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes,ISaltoConPatas
    {
        public Caballo(String nombreCaballo):base(nombreCaballo)
        {

        }
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        int IMamiferosTerrestres.NumeroPatas(){
            return 4;
        }
        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
        public string TipoDeporte()
        {
            return "Hípica";
        }
        public bool EsOlimpico()
        {
            return true;
        }
    }
    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }
    }
    class Adolescente : Humano
    {
        public Adolescente(string nombreAdolescente) : base(nombreAdolescente)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Las hormonas me impiden pensar con claridad");
        }
    }
    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public override void Pensar(){
            System.Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public int NumeroPatas(){
            return 2;
        }
    }
    class Chimpance : Gorila
    {
        public Chimpance(string nombreChimpance) : base(nombreChimpance)
        {

        }
    }
}

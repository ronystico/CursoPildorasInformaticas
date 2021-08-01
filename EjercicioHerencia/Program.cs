using System;

namespace EjercicioHerencia
{
    class Program
    {
        // Doy el ejercicio por terminado, lo hice con lo que sé y hubieron cosas que fallaron
        // Declarar array de objetos entre llaves {}
        // Acceder a las propiedades desde un método diferente

        // El plan es no pausar la grabación para que no haya trampa
        // Lo único que se me ocurre es crear el método get
        // Estuve pensando si había forma de usar la variable en otro método aún siendo
        // private y no recuerdo (otro estudio mas)

        // Jaja el problema es que no funciona en los otros metodos
        static void Main(string[] args)
        {
            // Hmm, a probar algo
            Transporte transporte = new Transporte(28,35);
            Transporte avion = new Avion(38,13);
            Transporte vehiculo = new Vehiculo(12,52);
            Transporte coche = new Coche(98,32);

            transporte.Conducir();
            transporte.getPropiedades();
            System.Console.WriteLine();

            avion.Conducir();
            avion.getPropiedades();
            System.Console.WriteLine();

            vehiculo.Conducir();
            vehiculo.getPropiedades();
            System.Console.WriteLine();

            coche.Conducir();
            coche.getPropiedades();
            System.Console.WriteLine();

            // La prueba era el principio de sustitución
            // Las variables son tipo transporte, y los objetos de tipos
            // que heredan transporte

            // A probar los array de objetos
            Transporte[] arrayTransporte = new Transporte[4];
            // No recuerdo cómo se hace así, por eso es importante practicar
            // arrayTransporte = {new Transporte(21,35),new Avion(24,76)};

            // De otra forma
            arrayTransporte[0] = new Transporte(25,72);
            arrayTransporte[1] = new Avion(26,78);
            arrayTransporte[2] = new Vehiculo(66,21);
            arrayTransporte[3] = new Coche(53,46);

            // hmm funciona, tal vez no era lo que esperabas, pero...
            //for(int i = 0;i < arrayTransporte.Length;i++){
            //    arrayTransporte[i].Conducir();
            //    arrayTransporte[i].getPropiedades();
            //    System.Console.WriteLine();
            //}

            // Olvidé lo mas importante, que muestre el resultado de sus propiedades
            // Faltó el $
        }
    }
    class Transporte {
        // no es que private lo resuelva, es para respetar convención
        private double alto;
        private double ancho;
        public Transporte(double alto,double ancho){
            this.alto = alto;
            this.ancho = ancho;
        }
        public void Arrancar(){

        }
        public void Parar(){

        }
        public virtual void Conducir(){
            System.Console.WriteLine($"Soy un medio de transporte que conduce de alto {alto} y ancho {ancho}");
        }
        public void getPropiedades(){
            System.Console.WriteLine($"Mis propiedades son: Alto {alto} Ancho {ancho}");
        }
    }
    class Avion : Transporte{
public Avion(double alto, double ancho):base(alto,ancho) {

}
public override void Conducir(){
    System.Console.WriteLine($"Soy un avión y puedo conducir");
}
    }
    class Vehiculo : Transporte{
        public Vehiculo(double alto,double ancho):base(alto,ancho){

        }
        public override void Conducir()
        {
            System.Console.WriteLine($"Soy un vehículo (al parecer, genérico) que puede conducir");
        }
    }
    class Coche : Transporte {
        public Coche(double alto,double ancho):base(alto,ancho){

        }
        public override void Conducir()
        {
            System.Console.WriteLine($"Soy un coche que puede conducir");
        }
    }
}

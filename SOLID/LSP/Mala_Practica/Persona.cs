namespace PrincipiosSolid.LSP.Mala_Practica
{
    public static class Main
    {
        public static void Aplicacion()
        {
            Persona niño = new Infante(5, "Raul", "");
            Persona adulto = new Adulto(35, "UPC", "Daniel Barros");

            // Mala practica
            niño.Votar();
        }
    }

    public abstract class Persona
    {
        public int Edad { get; set; }
        public string Nombres { get; set; }
        public string SitioVotacion { get; set; }

        protected Persona(int edad, string nombres, string sitioVotacion)
        {
            Edad = edad;
            Nombres = nombres;
            SitioVotacion = sitioVotacion;
        }

        public virtual void Presentarse()
        {
            Console.WriteLine($"Hola soy {Nombres} y tengo {Edad} años");
        }

        public abstract void Votar();
    }

    public class Infante : Persona
    {
        public Infante(int edad, string nombres, string sitioVotacion) : base(edad, nombres, sitioVotacion)
        {
        }

        public override void Votar()
        {
            throw new NotImplementedException();
        }
    }

    public class Adulto : Persona
    {
        public Adulto(int edad, string nombres, string sitioVotacion) : base(edad, nombres, sitioVotacion)
        {
        }

        public override void Votar()
        {
            Console.WriteLine($"Soy un adulto y voto en {SitioVotacion}");
        }
    }
}

namespace PrincipiosSolid.LSP.Buena_Practica
{
    public static class Main
    {
        public static void Aplicacion()
        {
            Persona niño = new Infante(5, "Raul");
            PersonaQueVota adulto = new Adulto("UPC", 38, "Daniel Barros");
            PersonaQueVota jovenAdulto = new JovenAdulto("El Copey", 26, "Maria");

            niño.Presentarse();
            adulto.Presentarse();
            adulto.Votar();
            jovenAdulto.Presentarse();
            jovenAdulto.Votar();
        }
    }

    public abstract class Persona
    {
        public int Edad { get; set; }
        public string Nombres { get; set; }

        protected Persona(int edad, string nombres)
        {
            Edad = edad;
            Nombres = nombres;
        }

        public virtual void Presentarse()
        {
            Console.WriteLine($"Hola soy {Nombres} y tengo {Edad} años");
        }
    }

    public abstract class PersonaQueVota : Persona
    {
        public string SitioVotacion { get; set; }
        public PersonaQueVota(string sitioVotacion, int edad, string nombres) : base(edad, nombres)
        {
            SitioVotacion = sitioVotacion;
        }

        public void Votar()
        {
            Console.WriteLine($"Estoy votando en {SitioVotacion}");
        }
    }

    public class Infante : Persona
    {
        public Infante(int edad, string nombres) : base(edad, nombres)
        {
        }
    }

    public class Adulto : PersonaQueVota
    {
        public Adulto(string sitioVotacion, int edad, string nombres) : base(sitioVotacion, edad, nombres)
        {
        }
    }

    public class JovenAdulto : PersonaQueVota
    {
        public JovenAdulto(string sitioVotacion, int edad, string nombres) : base(sitioVotacion, edad, nombres)
        {
        }
    }
}


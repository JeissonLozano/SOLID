namespace PrincipiosSolid.SRP.Buena_Practica
{
    public class Domiciliario
    {
        public int Identificacion { get; set; }
        public string Nombres { get; set; }

        public Domiciliario(int identificacion, string nombres)
        {
            Identificacion = identificacion;
            Nombres = nombres;
        }

        public void EntragarPizza()
        {
            Console.WriteLine("Entregar Pizza");
        }
    }
}

namespace PrincipiosSolid.SRP.Mala_Practica
{
    public class Pizza
    {
        public string Nombre { get; set; }
        public List<string> Ingredientes { get; set; }
        public decimal Precio { get; set; }

        public Pizza(string nombre, List<string> ingredientes, decimal precio)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            Precio = precio;
        }

        public void EntragarPizza()
        {
            Console.WriteLine("¿Entregar Pizza?");
        }
    }
}

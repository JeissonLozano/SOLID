namespace PrincipiosSolid.DIP
{
    public class Pizza
    {
        public string Tipo { get; set; }
        public decimal Precio { get; set; }

        public Pizza(string tipo, decimal precio)
        {
            Tipo = tipo;
            Precio = precio;
        }
    }
}

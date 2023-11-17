namespace PrincipiosSolid.ISP.Buena_Practica
{
    public interface IHorneable
    {
        void Hornear();
    }

    public interface IIngredienteEspecial
    {
        void AgregarIngredienteEspecial();
    }
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

    public class PizzaVegetariana : Pizza, IHorneable
    {
        public PizzaVegetariana(string tipo, decimal precio) : base(tipo, precio)
        {
        }

        public void Hornear()
        {
            Console.WriteLine($"Horneando la Pizza Margherita - {Tipo}");
        }
    }

    public class PizzaPepperoni : Pizza, IHorneable, IIngredienteEspecial
    {
        public PizzaPepperoni(string tipo, decimal precio) : base(tipo, precio)
        {
        }

        public void Hornear()
        {
            Console.WriteLine($"Horneando la Pizza Pepperoni - {Tipo}");
        }

        public void AgregarIngredienteEspecial()
        {
            Console.WriteLine($"Agregando ingrediente especial a la Pizza Pepperoni - {Tipo}");
        }
    }
}

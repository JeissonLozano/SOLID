using PrincipiosSolid.ISP.Buena_Practica;

namespace PrincipiosSolid.ISP.Mala_Practica
{
    public interface IPreparacion
    {
        void Hornear();
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

    public class PizzaPepperoni : Pizza, IPreparacion
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

    public class PizzaVegetariana : Pizza, IPreparacion
    {
        public PizzaVegetariana(string tipo, decimal precio) : base(tipo, precio)
        {
        }

        public void AgregarIngredienteEspecial()
        {
            throw new NotImplementedException();
        }

        public void Hornear()
        {
            Console.WriteLine($"Horneando la Pizza Margherita - {Tipo}");
        }
    }
}

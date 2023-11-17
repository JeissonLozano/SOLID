namespace PrincipiosSolid.OCP.Buena_Practica
{
    public class Pizza
    {
        public Pizza() { }

        public virtual void Descripcion() 
        {
            Console.WriteLine("Metodo para sobreescribir.");
        }
    }

    public class PizzaVegetariana : Pizza
    {
        public override void Descripcion()
        {
            Console.WriteLine("Pizza Vegetariana ...");
        }
    }

    public class PizzaHawaiana : Pizza
    {
        public override void Descripcion()
        {
            Console.WriteLine("Pizza Hawaiana ...");
        }
    }

}

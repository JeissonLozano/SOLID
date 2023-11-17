namespace PrincipiosSolid.OCP.Mala_practica
{
    public class Pizza
    {
        public string TipoPizza { get; set; }

        public Pizza(string tipoPizza)
        {
            TipoPizza = tipoPizza;
        }

        public void Descripción()
        {
            if (TipoPizza == "Hawaiana")
            {
                Console.WriteLine("Preparando pizza hawaina");
            }

            if (TipoPizza == "Vegetariana")
            {
                Console.WriteLine("Preparando pizza Vegetariana");
            }

            if (TipoPizza == "Mexicana")
            {
                Console.WriteLine("Preparando pizza Mexicana");
            }
        }
    }
}

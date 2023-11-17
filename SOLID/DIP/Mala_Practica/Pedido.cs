namespace PrincipiosSolid.DIP.Mala_Practica
{
    public interface IEntregaPizza
    {
        void EntregarPizza(Pizza pizza);
    }

    public interface IPizzaService
    {
        void PrepararPizza(Pizza pizza);
    }

    public class ServicioEntrega : IEntregaPizza
    {
        public void EntregarPizza(Pizza pizza)
        {
            Console.WriteLine($"Entregando la pizza {pizza.Tipo}...");
            // Lógica para la entrega de la pizza
            Console.WriteLine($"Pizza {pizza.Tipo} entregada.");
        }
    }

    public class Pizzeria : IPizzaService
    {
        public void PrepararPizza(Pizza pizza)
        {
            Console.WriteLine($"Preparando la pizza {pizza.Tipo}...");
            // Lógica para preparar la pizza
            Console.WriteLine($"Pizza {pizza.Tipo} preparada.");
        }
    }

    public class Pedido
    {
        private readonly Pizzeria _pizzaService;
        private readonly ServicioEntrega _entregaPizza;

        public Pedido()
        {
            _pizzaService = new Pizzeria();
            _entregaPizza = new ServicioEntrega();
        }

        public void ProcesarPedido(Pizza pizza)
        {
            _pizzaService.PrepararPizza(pizza);
            _entregaPizza.EntregarPizza(pizza);
            Console.WriteLine($"Pedido de pizza {pizza.Tipo} procesado.");
        }
    }
}

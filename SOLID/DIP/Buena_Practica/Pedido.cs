namespace PrincipiosSolid.DIP.Buena_Practica
{
    public interface IEntregaPizza
    {
        void EntregarPizza(Pizza pizza);
    }

    public interface IPizzaService
    {
        void PrepararPizza(Pizza pizza);
    }

    public class Pedido
    {
        private readonly IPizzaService _pizzaService;
        private readonly IEntregaPizza _entregaPizza;

        public Pedido(IPizzaService pizzaService, IEntregaPizza entregaPizza)
        {
            _pizzaService = pizzaService;
            _entregaPizza = entregaPizza;
        }

        public void ProcesarPedido(Pizza pizza)
        {
            _pizzaService.PrepararPizza(pizza);
            _entregaPizza.EntregarPizza(pizza);
            Console.WriteLine($"Pedido de pizza {pizza.Tipo} procesado.");
        }
    }
}

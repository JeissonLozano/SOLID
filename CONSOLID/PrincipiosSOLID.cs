namespace Principios.CONSOLID;

// Principio de Responsabilidad Única (SRP)
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
}

// Principio de Abierto/Cerrado (OCP)
public interface IPizzaService
{
    void PrepararPizza(Pizza pizza);
}

public class Pizzeria : IPizzaService
{
    public void PrepararPizza(Pizza pizza)
    {
        Console.WriteLine($"Preparando la pizza {pizza.Nombre}...");
        // Lógica para preparar la pizza
        Console.WriteLine($"Pizza {pizza.Nombre} preparada.");
    }
}

// Principio de Sustitución de Liskov (LSP)
public class PizzaEspecial : Pizza
{
    public string TipoEspecial { get; set; }

    public PizzaEspecial(string nombre, List<string> ingredientes, decimal precio, string tipoEspecial)
        : base(nombre, ingredientes, precio)
    {
        TipoEspecial = tipoEspecial;
    }
}

// Principio de Segregación de la Interfaz (ISP)
public interface IEntregaPizza
{
    void EntregarPizza(Pizza pizza);
}

public class ServicioEntrega : IEntregaPizza
{
    public void EntregarPizza(Pizza pizza)
    {
        Console.WriteLine($"Entregando la pizza {pizza.Nombre}...");
        // Lógica para la entrega de la pizza
        Console.WriteLine($"Pizza {pizza.Nombre} entregada.");
    }
}

// Principio de Inversión de Dependencia (DIP)
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
        Console.WriteLine($"Pedido de pizza {pizza.Nombre} procesado.");
    }
}
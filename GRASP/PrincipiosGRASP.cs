namespace Principios.GRASP;

// Principio de Asignación de Responsabilidad
public class Pedido
{
    public Pizza Pizza { get; set; }
    public Cliente Cliente { get; set; }

    public Pedido(Pizza pizza, Cliente cliente)
    {
        Pizza = pizza;
        Cliente = cliente;
    }

    public void RealizarPedido()
    {
        Console.WriteLine($"Cliente {Cliente.Nombre} ha realizado un pedido de pizza {Pizza.Nombre}.");
        // Lógica para realizar el pedido
        Console.WriteLine($"Preparando pizza {Pizza.Nombre}...");
        Console.WriteLine($"Pizza {Pizza.Nombre} preparada y entregada a {Cliente.Nombre} en la dirección: {Cliente.Direccion}.");
    }
}

// Principio de Experto en Información
public class Pizza
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}

public class Cliente
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
}

// Principio de Controlador
public class Pizzeria
{
    private List<Pedido> pedidos;

    public Pizzeria()
    {
        pedidos = new List<Pedido>();
    }

    public void TomarPedido(Pedido pedido)
    {
        pedidos.Add(pedido);
        pedido.RealizarPedido();
    }
}

// Principio de Polimorfismo
public class PizzaMargarita : Pizza
{
    public PizzaMargarita()
    {
        Nombre = "Margarita";
        Precio = 8.99m;
    }
}

public class PizzaPepperoni : Pizza
{
    public PizzaPepperoni()
    {
        Nombre = "Pepperoni";
        Precio = 10.99m;
    }
}


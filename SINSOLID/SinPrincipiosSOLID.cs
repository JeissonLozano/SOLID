namespace Principios.SINSOLID;

public class Pizza
{
    public string Nombre { get; set; }
    public List<string> Ingredientes { get; set; }
    public decimal Precio { get; set; }
}

public class Pizzeria
{
    public void PrepararPizza(Pizza pizza)
    {
        Console.WriteLine($"Preparando la pizza {pizza.Nombre}...");

        if (pizza.Nombre == "Hawaina")
        {
            Console.WriteLine("Se agrega extraqueso");
        }
        else if (pizza.Nombre == "Vegetariana")
        {
            Console.WriteLine("SeAgrega pimenton");
        }
        else
        {
            Console.WriteLine("Se agrega jamon");
        }

        // Lógica para preparar la pizza
        Console.WriteLine($"Pizza {pizza.Nombre} preparada.");
    }

    public void EntregarPizza(Pizza pizza)
    {
        Console.WriteLine($"Entregando la pizza {pizza.Nombre}...");
        // Lógica para la entrega de la pizza
        Console.WriteLine($"Pizza {pizza.Nombre} entregada.");
    }
}

public class Pedido
{
    public void ProcesarPedido(Pizza pizza)
    {
        var pizzeria = new Pizzeria();
        pizzeria.PrepararPizza(pizza);

        var servicioEntrega = new Pizzeria();
        servicioEntrega.EntregarPizza(pizza);

        Console.WriteLine($"Pedido de pizza {pizza.Nombre} procesado.");
    }
}

//Con los principios GRASP

Console.WriteLine("\nCon los principios GRASP...\n");

var clienteGRASP = new Principios.GRASP.Cliente { Nombre = "Juan", Direccion = "Calle Principal" };
var pizzaGRASP = new Principios.GRASP.PizzaMargarita();

var pedidoGRASP = new Principios.GRASP.Pedido(pizzaGRASP, clienteGRASP);
var pizzeriaGRASP = new Principios.GRASP.Pizzeria();

pizzeriaGRASP.TomarPedido(pedidoGRASP);

Console.ReadLine();
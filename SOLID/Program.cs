using Principios.CONSOLID;

//---------------------------------------------------------------------------------------------------------------------------

//Con los principios SOLID

//Ejemplo del Principio de Responsabilidad Única (SRP)...

Console.WriteLine("Ejemplo del Principio de Responsabilidad Única (SRP)...\n");

var pizzaSRP = new Pizza("Hawaiana", new List<string> { "Jamón", "Piña", "Salsa de tomate", "Queso" }, 12.99m);

Console.WriteLine($"Pizza: {pizzaSRP.Nombre}, Precio: {pizzaSRP.Precio:C}");

//Ejemplo del Principio de Abierto/Cerrado (OCP)... //Ajustar

Console.WriteLine("\nEjemplo del Principio de Abierto/Cerrado (OCP)...\n");

var pizzaOCP = new Pizza("Hawaiana", new List<string> { "Jamón", "Piña", "Salsa de tomate", "Queso" }, 12.99m);

Console.WriteLine($"Pizza: {pizzaOCP.Nombre}, Precio: {pizzaOCP.Precio:C}");

//Ejemplo del Principio de Sustitución de Liskov (LSP)...

Console.WriteLine("\nEjemplo del Principio de Sustitución de Liskov (LSP)...\n");

Pizza pizzaLSP = new PizzaEspecial("Suprema", new List<string> { "Jamón", "Salchicha", "Champiñones", "Queso" }, 14.99m, "Especial");

Console.WriteLine($"Pizza: {pizzaLSP.Nombre}, Precio: {pizzaLSP.Precio:C}");

//Ejemplo del Principio de Segregación de la Interfaz (ISP)...

Console.WriteLine("\nEjemplo del Principio de Segregación de la Interfaz (ISP)...\n");

var pizzeriaISP = new Pizzeria();
var servicioEntregaISP = new ServicioEntrega();

var pizzaISP = new Pizza("Hawaiana", new List<string> { "Jamón", "Piña", "Salsa de tomate", "Queso" }, 12.99m);

pizzeriaISP.PrepararPizza(pizzaISP);
servicioEntregaISP.EntregarPizza(pizzaISP);

//Ejemplo del Principio de Inversión de Dependencia (DIP)...

Console.WriteLine("\nEjemplo del Principio de Inversión de Dependencia (DIP)...\n");

var pizzeriaDIP = new Pizzeria();
var servicioEntregaDIP = new ServicioEntrega();

var pedidoDIP = new Pedido(pizzeriaDIP, servicioEntregaDIP);
var pizzaDIP = new Pizza("Hawaiana", new List<string> { "Jamón", "Piña", "Salsa de tomate", "Queso" }, 12.99m);

pedidoDIP.ProcesarPedido(pizzaDIP);

//---------------------------------------------------------------------------------------------------------------------------

//Sin los principios SOLID

Console.WriteLine("\nSin los principios SOLID...\n");

var pizzaSinSolid = new Principios.SINSOLID.Pizza { Nombre = "Hawaiana", Precio = 12.99m };

var pedidoSinSolid = new Principios.SINSOLID.Pedido();
pedidoSinSolid.ProcesarPedido(pizzaSinSolid);

//---------------------------------------------------------------------------------------------------------------------------

//Con los principios GRASP

Console.WriteLine("\nCon los principios GRASP...\n");

var clienteGRASP = new Principios.GRASP.Cliente { Nombre = "Juan", Direccion = "Calle Principal" };
var pizzaGRASP = new Principios.GRASP.PizzaMargarita();

var pedidoGRASP = new Principios.GRASP.Pedido(pizzaGRASP, clienteGRASP);
var pizzeriaGRASP = new Principios.GRASP.Pizzeria();

pizzeriaGRASP.TomarPedido(pedidoGRASP);

Console.ReadLine();
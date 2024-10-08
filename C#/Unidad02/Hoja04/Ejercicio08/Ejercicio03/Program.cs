class Cliente : IComparer<Cliente>
{
    public string Nombre { get; set; }
    public double ImporteFacturacion { get; set; }
    public DateTime FechaAlta { get; set; }
    public DateTime FechaUltimaVenta { get; set; }

    public int Compare(Cliente x, Cliente y)
    {
        return x.Nombre.CompareTo(y.Nombre);
    }
}


class Program {
    static List<Cliente> clientes = new List<Cliente>();

    static void Main() {
        while (true) {
            Console.WriteLine("1. Dar de alta cliente");
            Console.WriteLine("2. Mostrar clientes ordenados por nombre");
            Console.WriteLine("3. Mostrar clientes ordenados por importe de facturación");
            Console.WriteLine("4. Mostrar clientes ordenados por fecha de alta");
            Console.WriteLine("5. Mostrar clientes ordenados por fecha de última venta");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion) {
                case 1:
                    DarDeAltaCliente();
                    break;
                case 2:
                    MostrarClientesOrdenados("nombre");
                    break;
                case 3:
                    MostrarClientesOrdenados("importe");
                    break;
                case 4:
                    MostrarClientesOrdenados("fechaAlta");
                    break;
                case 5:
                    MostrarClientesOrdenados("fechaUltimaVenta");
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void DarDeAltaCliente() {
        if (clientes.Count >= 10) {
            Console.WriteLine("No se pueden dar de alta más de 10 clientes.");
            return;
        }

        Cliente cliente = new Cliente();
        Console.Write("Nombre: ");
        cliente.Nombre = Console.ReadLine();
        Console.Write("Importe de facturación: ");
        cliente.ImporteFacturacion = double.Parse(Console.ReadLine());
        Console.Write("Fecha de alta (dd/MM/yyyy): ");
        cliente.FechaAlta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Fecha de última venta (dd/MM/yyyy): ");
        cliente.FechaUltimaVenta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        clientes.Add(cliente);
    }

    static void MostrarClientesOrdenados(string criterio) {
        List<Cliente> clientesOrdenados = new List<Cliente>(clientes);

        switch (criterio) {
            case "nombre":
                clientesOrdenados.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
                break;
            case "importe":
                clientesOrdenados.Sort((x, y) => x.ImporteFacturacion.CompareTo(y.ImporteFacturacion));
                break;
            case "fechaAlta":
                clientesOrdenados.Sort((x, y) => x.FechaAlta.CompareTo(y.FechaAlta));
                break;
            case "fechaUltimaVenta":
                clientesOrdenados.Sort((x, y) => x.FechaUltimaVenta.CompareTo(y.FechaUltimaVenta));
                break;
        }

        foreach (var cliente in clientesOrdenados) {
            Console.WriteLine($"Nombre: {cliente.Nombre}, Importe: {cliente.ImporteFacturacion}, Fecha de Alta: {cliente.FechaAlta.ToString("dd/MM/yyyy")}, Fecha de Última Venta: {cliente.FechaUltimaVenta.ToString("dd/MM/yyyy")}");
        }
    }
}


/*
 * 
 * 3. Interfaces, ordenación, IComparer. Crea una clase Cliente con las propiedades nombre, importe facturación, fecha de alta, fecha de ultima venta. 
 * Los campos de tipo fecha serán del tipo DateTime y solo se tendrán en cuenta el día, mes y año. Implementar mediante IComparer un comparador para cada una de las propiedades. 
 * Crear una aplicación que mediante un menú me permita dar de alta hasta 10 clientes y mostrarlos ordenados según la propiedad que indique el usuario.
 * 
 * */
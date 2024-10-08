public class Producto : IComparable{     
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(string nombre, double precio) {
        Nombre = nombre;
        Precio = precio;
    }

    public int CompareTo(object? obj) {
        double precio = ((Producto)obj).Precio;
        if (Precio > precio) {
            return 1;
        } else if (Precio < precio) {
            return -1;
        } else {
            return 0;
        }
    }
}

class Program {
    static void Main() {
        List<Producto> productos = new List<Producto>();
        productos.Add(new Producto("Producto 1", 100));
        productos.Add(new Producto("Producto 2", 50));
        productos.Add(new Producto("Producto 3", 200));
        productos.Add(new Producto("Producto 4", 150));
        productos.Add(new Producto("Producto 5", 300));

        productos.Sort();
        foreach (Producto producto in productos) {
            Console.WriteLine(producto.Nombre + " - " + producto.Precio);
        }
    }
}

/*
 * 
 * 11. Crea una clase llamada Producto que tenga propiedades para Nombre y Precio. Luego implementa un comparador que ordene los productos por precio
 * 
 */
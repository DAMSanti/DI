int[] monedas = { 100, 50, 20, 10, 5, 2, 1 };

Console.WriteLine("Introduce un precio a pagar: ");
int precio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce el dinero pagado: ");
int pagado = Convert.ToInt32(Console.ReadLine());

int cambio = pagado - precio;

Console.WriteLine($"Su cambio es de {cambio}:");


Console.WriteLine(string.Join(" ", monedas.Select(m => {
                            int cantidad = cambio / m;
                            cambio %= m;
                            return cantidad > 0 ? $"{cantidad} monedas de {m} " : "";
                            })
                .Where(m => m != "")));


/*
 * 4. Crear un programa que devuelva el cambio de una compra, utilizando monedas (o billetes) 
 * del mayor valor posible. Supondremos que tenemos una cantidad ilimitada de monedas (o billetes) 
 * de 100, 50, 20, 10, 5, 2 y 1, y que no hay decimales. La ejecución podría ser algo como:

Precio? 44

Pagado? 100

Su cambio es de 56: 50 5 1

Precio? 1

Pagado? 100

Su cambio es de 99: 50 20 20 5 2 2

*/
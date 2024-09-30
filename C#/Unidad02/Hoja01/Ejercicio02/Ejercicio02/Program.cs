try
{
    Boolean salir = false;
    while (!salir)
    {
        Console.WriteLine("Calculadora de par/impar");

        Console.WriteLine("Introduce un número entero:");

        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0) {
            Console.WriteLine("El número es par");
        } else {
            Console.WriteLine("El número es impar");
        }

        Console.WriteLine("¿Quieres salir de la aplicación? (s/n)");
        String respuesta = Console.ReadLine();
        if (respuesta == "s")
        {
            salir = true;
        }
    }

} catch (Exception ex) {
    Console.WriteLine("Error: " + ex.Message);
}

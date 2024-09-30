try
{
    Boolean salir = false;
    while (!salir)
    {
        Console.WriteLine("Calculadora de factoriales");

        Console.Write("Introduce un número entero positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        int resultado = numero;

        for (int i = numero - 1; i > 0; i--)
        {
            resultado *= i;
        }

        Console.WriteLine("El factorial de {0} es {1}", numero, resultado);

        Console.WriteLine("¿Quieres salir? (s/n)");
        if (Console.ReadLine().ToLower() == "s")
        {
            salir = true;
        }
    }
} catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}
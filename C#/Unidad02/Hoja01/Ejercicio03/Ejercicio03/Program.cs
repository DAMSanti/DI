try
{
    Boolean salir = false;
    while (!salir)
    {
        Console.WriteLine("Calculadora de tablas de multiplicar");

        Console.Write("Introduce un número: ");

        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }

        Console.WriteLine("Quiere consultar otra tabla de multiplicar? (s/n)");
        String respuesta = Console.ReadLine();
        if (respuesta == "n") {
            salir = true;
        }
    }
} catch (Exception ex) {
    Console.WriteLine("Error: " + ex.Message);
}

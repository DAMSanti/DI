try
    {
    Boolean salir = false;
    while (!salir) {
        Console.WriteLine("Programa de operaciones aritméticas básicas\n");

        Console.Write("Introduzca por favor un numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduzca por favor un segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\n\nLa suma de los dos números es: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(numero1 + numero2);
        Console.ResetColor();
        Console.Write("La resta de los dos números es: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(numero1 - numero2);
        Console.ResetColor();
        Console.Write("La multiplicación de los dos números es: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(numero1 * numero2);
        Console.ResetColor();
        Console.Write("La división de los dos números es: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(numero1 / numero2);
        Console.ResetColor();
        Console.Write("El resto de la división de los dos números es: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(numero1 % numero2);
        Console.ResetColor();

        Console.WriteLine("\n\nQuiere volver a realizar una operacion? (s/n)");
        string respuesta = Console.ReadLine();
        if (respuesta == "n")
        {
            Console.WriteLine("Gracias por utilizar el programa");
            salir = true;
        }
    }
} catch (Exception ex) {
    Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
}



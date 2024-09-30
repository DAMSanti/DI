try {
    Boolean salir = false;

    while (!salir) {
        Console.WriteLine("Calculadora de mayor número");

        Console.WriteLine("Introduce el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el tercer número:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine("Los tres números son iguales");
        }
        else
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El número mayor es: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El número mayor es: " + num2);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + num3);
            }
        }

        Console.WriteLine("¿Quieres salir de la aplicación? (s/n)");
        String respuesta = Console.ReadLine();
        if (respuesta == "s") {
            salir = true;
        }
    }
} catch (Exception ex) {
    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
}
try
{
    Boolean salir = false;

    while (!salir)
    {
        Console.WriteLine("Calculadora de números primos");
        
        Console.WriteLine("Introduce un número entero positivo:");
        int numero = Convert.ToInt32(Console.ReadLine());
        Boolean esPrimo = false;
        for (int i = 2; i < numero; i++) {
            if (numero % i == 0) {
                esPrimo = true;
                break;
            }
        }
        Console.WriteLine("El número " + numero + " es " + (esPrimo ? "no primo" : "primo"));
    }
} catch (Exception ex) {
   Console.WriteLine("Error: " + ex.Message);
}
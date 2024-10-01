Boolean salir = false;
while (!salir) {
    Console.Write("Introduce un número para saber si es primo: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    bool esPrimo = true;

    for (int i = 2; i < numero; i++) {
        if (numero % i == 0) {
            esPrimo = false;
            break;
        }
    }

    if (esPrimo) {
        Console.WriteLine("El número {0} es primo", numero);
    } else {
        Console.WriteLine("El número {0} no es primo", numero);
    }

    Console.Write("¿Quieres salir? (s/n): ");
    salir = Console.ReadLine().ToLower() == "s";
}


/*
 * 
 * 3. for. Escribe un programa que me diga si un numero es primo, un numero es primo cuando solamente es divisible por 1 y por el mismo. Implementar mediante un bucle for.
 * 
 */
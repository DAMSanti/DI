try {
    Boolean salir = false;
    Boolean valido = false;
    int operando1 = 0;
    char operador = ' ';
    int operando2 = 0;
    int resultado = 0;
    while (!salir) {
        while (!valido) {
            Console.Write("Introduce un numero entero: ");
            operando1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce un operador: ");
            operador = Convert.ToChar(Console.ReadLine());

            Console.Write("Introduce otro numero entero: ");
            operando2 = Convert.ToInt32(Console.ReadLine());

            resultado = 0;

            switch (operador) {
                case '+':
                    resultado = operando1 + operando2;
                    valido = true;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    valido = true;
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    valido = true;
                    break;
                case '/':
                    resultado = operando1 / operando2;
                    valido = true;
                    break;
                case '%':
                    resultado = operando1 % operando2;
                    valido = true;
                    break;
                default:
                    Console.WriteLine("Operador no soportado");
                    break;
            }
        }
        
        Console.WriteLine("El resultado de '{0}{1}{2}' es igual a '{3}'", operando1, operador, operando2, resultado);

        Console.WriteLine("¿Quieres salir? (s/n)");

        if (Console.ReadLine().ToLower() == "s") {
            salir = true;
        } else {
            valido = false;
        }
    }
} catch (Exception e) {
    Console.WriteLine("Error: " + e.Message);
}


/*
1.Convert, switch.Escribe un programa que me solicite un número entero (operando1), 
  seguido que me solicite un operador, seguido que me solicite un número entero (operando2). 
  El programa mostrara por pantalla el resultado con el siguiente formato. "El resultado de 'operando1''operador''operando2' es igual a 'resultado calculado'"
  Los operadores disponibles soportados serán: +, -, *, /, %

*/
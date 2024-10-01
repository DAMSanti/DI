Console.WriteLine("Introduce un número entero:");
int number = Convert.ToInt32(Console.ReadLine());

int reverse = 0;

int temp = number;

while (temp != 0)
{
    reverse = reverse * 10 + temp % 10;
    temp /= 10;
}

Console.WriteLine( number == reverse ? "El número es capicúa" : "El número no es capicúa");


/*
 * 6. Crea un programa que verifique si un número entero es capicúa (si se lee igual de izquierda a derecha que de derecha a izquierda). 
 * El programa deberá solicitar un número y devolver un mensaje que indique si es capicúa o no.
 * 
 */
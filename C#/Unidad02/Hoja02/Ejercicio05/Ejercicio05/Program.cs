Console.WriteLine("Introduce una cadena de texto:");
string cadena = Console.ReadLine();

int contador = 0;

for (int i = 0; i < cadena.Length; i++)
{
    if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
    {
        contador++;
    }
}

Console.WriteLine($"El número de vocales en la cadena es: {contador}");


/*
 * 5. Escribe un programa que solicite al usuario una cadena de texto y cuente cuántas vocales hay en esa cadena. Deberás mostrar el número de vocales totales.
 * 
 */
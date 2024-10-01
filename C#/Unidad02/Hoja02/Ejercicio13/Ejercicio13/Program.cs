int[,] matriz = new int[3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Ingrese el valor de la posición [{i}, {j}]: ");
        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

int suma = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        suma += matriz[i, j];
    }
}

Console.WriteLine($"La suma de todos los elementos de la matriz es: {suma}");


/*  13. Crea un programa que solicite al usuario llenar una matriz de 3x3 con números enteros y luego calcule la suma de todos los elementos de la matriz. */
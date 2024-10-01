int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

int sumaFila1 = 0;

for (int i = 0; i < 3; i++)
{
    sumaFila1 += matriz[0, i];
}

int sumaFila2 = 0;

for (int i = 0; i < 3; i++)
{
    sumaFila2 += matriz[1, i];
}

int sumaColumna1 = 0;

for (int i = 0; i < 2; i++)
{
    sumaColumna1 += matriz[i, 0];
}

int sumaColumna2 = 0;

for (int i = 0; i < 2; i++)
{
    sumaColumna2 += matriz[i, 1];
}

int sumaColumna3 = 0;

for (int i = 0; i < 2; i++)
{
    sumaColumna3 += matriz[i, 2];
}

Console.WriteLine($"Suma de la fila 1: {sumaFila1}");
Console.WriteLine($"Suma de la fila 2: {sumaFila2}");
Console.WriteLine($"Suma de la columna 1: {sumaColumna1}");
Console.WriteLine($"Suma de la columna 2: {sumaColumna2}");
Console.WriteLine($"Suma de la columna 3: {sumaColumna3}");

/* 14. Escribe una matriz de 2x3 (2 filas y 3 columnas) y calcule la suma de cada fila y de cada columna. */
int[,] notas = new int[3, 2];

Console.WriteLine("Ingrese las notas de los estudiantes");
for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 2; j++) {
        Console.Write($"Ingrese la nota {j + 1} del estudiante {i + 1}: ");
        notas[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 3; i++) {
    int suma = 0;
    for (int j = 0; j < 2; j++) {
        suma += notas[i, j];
    }
    Console.WriteLine($"El promedio del estudiante {i + 1} es: {suma / 2}");
}

int sumaTotal = 0;

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 2; j++) {
        sumaTotal += notas[i, j];
    }
}

Console.WriteLine($"El promedio total de todas las notas es: {sumaTotal / 6}");

/*12. Crea un programa que almacene las notas de varios estudiantes en diferentes asignaturas utilizando un array multidimensional. El programa deberá realizar lo siguiente:

a. Definir un array de tamaño 3x2, donde las filas representen a 3 estudiantes y las columnas las notas de dos asignaturas

b. Solicitar al usuario que escriba las notas de cada estudiante para ambas asignaturas

c. Calcular y mostrar el promedio de notas para cada estudiante

d. Calcular y mostrar el promedio total de todas las notas escritas.*/
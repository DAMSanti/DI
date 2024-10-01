Console.WriteLine("Escribe 5 números enteros");
int[] nums = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Número " + (i + 1) + ": ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

int sum = 0;

foreach (int num in nums)
{
    sum += num;
}

Console.WriteLine("La suma de los números es: " + sum);

/* 8. Escribe un programa que solicite al usuario una lista de 5 números enteros, los almacene en un array unidimensional y luego muestre la suma de esos números.
 */
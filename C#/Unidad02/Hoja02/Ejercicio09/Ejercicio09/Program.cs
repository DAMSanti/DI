int[] nums = new int[10];

Console.WriteLine("Ingrese 10 números enteros:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Número {i + 1}: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

int max = nums[0];

for (int i = 1; i < 10; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
}

Console.WriteLine($"El número máximo es: {max}");



/* 9. Escribe un programa que reciba 10 números enteros en un array y determine el valor máximo entre ellos. */
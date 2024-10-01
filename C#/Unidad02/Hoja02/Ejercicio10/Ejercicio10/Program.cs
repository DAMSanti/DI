int[] nums = new int[5];

Console.WriteLine("Escribe 5 números:");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"Número {i + 1}: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Números en orden inverso:");

for (int i = nums.Length - 1; i >= 0; i--)
{
    Console.WriteLine(nums[i]);
}


/* 11. Escribe un programa que permita el usuario escribir 5 números en un array y luego los muestre en orden inverso. */
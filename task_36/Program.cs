Random random = new Random();
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 101);
    Console.Write(array[i] + " ");
}

int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}

Console.WriteLine("\nСумма элементов с нечетными индексами: " + sum);

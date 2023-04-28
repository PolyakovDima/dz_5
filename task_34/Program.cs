Random random = new Random();
ushort[] array = new ushort[8];
int evenCount = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = (ushort)random.Next(100, 1000); // случайное трехзначное число
    Console.Write($"{array[i]} ");

    if (array[i] % 2 == 0) // проверка на четность
    {
        evenCount++;
    }
}

Console.WriteLine($"\nКоличество четных чисел: {evenCount}");

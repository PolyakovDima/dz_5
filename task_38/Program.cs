double[] array = { 3.14, -2.71, 1.618, 0, 2.718, -0.577, 1 };
double max = double.MinValue;
double min = double.MaxValue;

foreach (double number in array)
{
    if (number > max)
    {
        max = number;
    }
    if (number < min)
    {
        min = number;
    }
}

double diff = max - min;
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива: {diff}");
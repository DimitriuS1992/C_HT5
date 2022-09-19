// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] array = new double[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-25, 25) + rand.NextDouble();
}

double min = 0;
double max = 0;
foreach (int i in array)  // Поиск максимального и минимального значения
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");
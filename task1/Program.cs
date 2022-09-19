// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных
int count = 0;
int[] array = new int[10];
Random rand = new Random();
Console.WriteLine("Массив положительных трёхзначных чисел:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        count++;
}
Console.WriteLine();
Console.WriteLine($"Количество положительных элементов массива: {count}");
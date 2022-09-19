// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int summa = 0;
int[] array = new int[10];
Random rand = new Random();
Console.WriteLine("Исходный массив случайных чисел:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(20);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
        summa = summa + array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма нечётных элементов маасива равна {summa}");

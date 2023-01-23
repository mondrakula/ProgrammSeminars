// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}
int[] massive = GetRandomArray(10, 1, 100);
Console.WriteLine(string.Join(", ", massive));
int max = massive[0];
int min = massive[0];

for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] < min)
    {
        min = massive[i];
    }
    else
    {
        if (massive[i] > max)
        {
            max = massive[i];
        }
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна = {max-min}");

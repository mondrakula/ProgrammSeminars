// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}
int[] massive = GetRandomArray(13, 0, 10);
Console.WriteLine(string.Join(", ", massive));
int sumP = 0;

for (int i = 1; i < massive.Length; i=i+2)
{
    sumP+=massive[i]; 
}

Console.WriteLine($"Сумма стоящих на нечетных позициях чисел массива равна {sumP}");
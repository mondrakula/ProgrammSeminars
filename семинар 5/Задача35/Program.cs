// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}
int[] massive = GetRandomArray(123, 0, 150);
Console.WriteLine(string.Join(", ", massive));
int count =0;
for (int i = 0; i < massive.Length; i++)
{
    if(massive[i]>9 & massive[i]<100)
    {
        count++;
    }   
}
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно = {count}");
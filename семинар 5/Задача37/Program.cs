// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}
int[] array = GetRandomArray(6, 1, 10);
Console.WriteLine(string.Join(", ", array));
int size = (array.Length+1) / 2;
// int size = array.Length / 2 + array.Length % 2;
// if (array.Length % 2 == 0)
// {
//     size = array.Length / 2;
// }
// else
// {
//     size = array.Length / 2 + 1;
// }

int[] newArray = new int[size];

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}

if (array.Length % 2 == 1)
{
    newArray[size - 1] = array[array.Length / 2];
}
Console.WriteLine(string.Join(", ", newArray));
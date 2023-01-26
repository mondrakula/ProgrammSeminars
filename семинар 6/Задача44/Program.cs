// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
int[] Fibo(int size)
{
    int[] Arr = new int[size];
    Arr[0] = 0;
    Arr[1] = 1;
    for (int i = 2; i<size;i++)
    {
        Arr[i] = Arr[i-1] + Arr[i-2];
    }
    return Arr;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(", ",Fibo(number)));

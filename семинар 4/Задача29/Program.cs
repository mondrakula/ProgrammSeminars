// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем


int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"arr[{i}] = ");
    arr[i]= Convert.ToInt32(Console.ReadLine());
}
Console.Write("[");
Console.Write(string.Join(", ", arr));
Console.Write("]");
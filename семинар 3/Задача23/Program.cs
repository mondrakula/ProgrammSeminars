// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
double cube = 0;
Console.WriteLine($"Таблица кубов от 1 до {number}");
while (index<number+1)
{
    cube = Math.Pow(index, 2);
    Console.WriteLine(cube);
    index++;
}

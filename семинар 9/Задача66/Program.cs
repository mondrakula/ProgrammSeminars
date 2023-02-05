// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int sum = 0;
int Program(int m, int n)
{
    if (m-1 == n) return sum;
    sum+=m;
    Program(m + 1, n);
    return sum;
}
Console.Write("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"M={number1},N={number2} => ");
Console.WriteLine(Program(number1, number2));

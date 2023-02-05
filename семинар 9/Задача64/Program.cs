// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

void Program(int n)
{
    if(n==0) return;
    Console.Write(n+ " ");
    Program(n-1);
    
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"N={number} => ");
Program(number);
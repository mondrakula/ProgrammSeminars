// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string digit = Convert.ToString(number);
Console.WriteLine($"Вторая цифра числа {number} = {digit[1]}");

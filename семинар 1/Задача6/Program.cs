// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.Write("Напишите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0)
Console.WriteLine($"{number1} - четное число");
else 
Console.WriteLine($"{number1} - нечетное число");
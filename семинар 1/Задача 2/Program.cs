﻿// Задача 2: Напишите программу, 
//которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Напишите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
    Console.WriteLine($"Наибольшее число: {number1}");
else 
    Console.WriteLine($"Наибольшее число: {number2}");
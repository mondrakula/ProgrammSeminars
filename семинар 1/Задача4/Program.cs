// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
Console.Write("Напишите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2>max)
    max = number2;
    if (number3>max)
        max = number3;
Console.WriteLine($"Наибольшее число: {max}");

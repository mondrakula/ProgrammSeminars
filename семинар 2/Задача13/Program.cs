// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string digit = Convert.ToString(number);
if (digit.Length < 3)
{
    Console.WriteLine("У данного числа нет третьей цифры");
}
else
{
    Console.WriteLine($"Третья цифра числа {number} = {digit[2]}");
}



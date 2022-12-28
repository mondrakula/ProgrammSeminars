// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number.Length !=5)
{
    Console.WriteLine("Введите правильное ЧИСЛО!");
    return;
}
if (number[0]==number[4] || number[1]==number[3])
{
    Console.WriteLine($"{number} - палиндром");
}
else 
{
    Console.WriteLine($"{number} - не палиндром");
}
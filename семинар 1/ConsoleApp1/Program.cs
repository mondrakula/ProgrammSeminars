// See https://aka.ms/new-console-template for more information

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number2 * number2;
if(number1 == result)
    Console.WriteLine($"Квадрат = {result}");
else 
    Console.WriteLine("Первое число НЕ равняется квадратом второго");
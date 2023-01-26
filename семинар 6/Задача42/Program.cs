// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("Введите десятичное число для преобразования в двоичное: ");
int number = Convert.ToInt32(Console.ReadLine());
int initialNumber = number;
string num = "";
while (number > 0)
{
    num = Convert.ToString(number % 2) + num;
    number /= 2;
}
Console.WriteLine($"Число {initialNumber} в десятичной системе = {num}");
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = readnumber("Введите число А");

int SumOfDigits(int a)
{
    int sum = 0;
    int ostatok = 0;
    while (a / 10 != 0)
    {
        ostatok = a % 10;
        a = a / 10;
        sum += ostatok;
    }
    sum += a;
    return Math.Abs(sum); 
}

Console.WriteLine($"Сумма цифр в числе {number} равна: {SumOfDigits(number)}");
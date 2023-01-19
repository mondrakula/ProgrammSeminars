//  Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B(Не использовать Math.Pow() и аналоги!).

int readnumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = readnumber("Введите число А");
int b = readnumber("Введите число B");
int pow = 1;

for (int i = 0; i < b; i++)
{
    //pow = pow * a;
    pow *= a;
}

Console.WriteLine(pow);

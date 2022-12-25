// See https://aka.ms/new-console-template for more information

//Console.Write("Введите первое целое число: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе целое число: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int result = number2 * number2;
//if(number1 == result)
//    Console.WriteLine($"Квадрат = {result}");
//else 
//   Console.WriteLine("Первое число НЕ равняется квадратом второго");
Console.Clear();

int xa = 50, ya = 1,
xb = 1, yb = 30,
xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}
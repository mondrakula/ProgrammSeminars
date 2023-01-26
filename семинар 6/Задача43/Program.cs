// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("y = ax + c  y = bx + d");
Console.Write("Введите a: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c: ");
double c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите d: ");
double d = Convert.ToInt32(Console.ReadLine());

if(d==c & a==b)
{
    Console.WriteLine($"Прямые y = {a}x + {c} и y = {b}x + {d} одинаковы");
}
else if(d==c)
{
    Console.WriteLine($"Прямые y = {a}x + {c} и y = {b}x + {d} параллельны");
}
else
{
    double x = (d-c)/(a-b);
    double y = a*x+c;
    Console.WriteLine($"Точка пересечения прямых y = {a}x + {c} и y = {b}x + {d} равна [{x},{y}]");
}


// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if((a+b>c) & (a+c>b) & (b+c>a))
{
    Console.WriteLine($"Треугольник со сторонами {a},{b},{c} существует");
}
else
{
    Console.WriteLine($"Треугольник со сторонами {a},{b},{c} не существует");
}
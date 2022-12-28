// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.Clear();

int Point (string dot)
{
    Console.WriteLine($"Введите координату {dot}");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Point("x1"), y1 = Point("y1"), z1 = Point("z1"),
    x2 = Point("x2"), y2 = Point("y2"), z2 = Point("z2");
double result = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
Console.WriteLine(result);

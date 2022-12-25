// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Напишите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Ура, Выходные!");
}
else 
{
    Console.WriteLine("Не выходной :(");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int number = new Random().Next(1,10);
Console.WriteLine(number);
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет, Маша!");
}
else
{
    Console.WriteLine("Привет");
}

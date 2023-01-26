// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
//0, 7, 8, -2, -2 -> 2      1, -7, 567, 89, 223-> 4

Console.WriteLine("Вводите числа, для остановки напишите 'stop' ");
string? num = "";
int number = 0;
int count = 0;
string stop = "stop";
while(true)
{
    num = Console.ReadLine();
    if(num==stop)
    {
        break;
    }
    number = Convert.ToInt32(num);
    if (number>0)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел больше 0 равно = {count}");
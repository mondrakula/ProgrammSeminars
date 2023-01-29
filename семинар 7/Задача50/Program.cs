// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}   

Console.Write("Введите номер строки элемента = ");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента = ");
int stolb = Convert.ToInt32(Console.ReadLine());

const int ROWS = 4;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
if (stroka > array.GetLength(0) || stolb > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента не существует!");
    }
    else
    {
        Console.WriteLine($"matrix[{stroka},{stolb}]= {array[stroka-1, stolb-1]}");
    }
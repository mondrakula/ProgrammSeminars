// Задача 56: Задайте двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int MinSumElementsRow(int[,] matrix, int i)
{
    int sumRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumRow += matrix[i, j];
    }

    return sumRow;
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);

int minSumRow = 0;
int sumRow = MinSumElementsRow(array, 0);
for (int i = 0; i < array.GetLength(0)-1; i++)
{
  int tempSumLine = MinSumElementsRow(array, i);
  if (MinSumElementsRow(array, 0) > MinSumElementsRow(array, i+1))
  {
    sumRow = MinSumElementsRow(array, i+1);
    minSumRow = i+1;
  }
}

Console.WriteLine($"Строка с наименьшей суммой элементов({sumRow}): {minSumRow} строка");
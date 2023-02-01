// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MatrixMultiplication(int [,] matrix, int [,] matrix2)
{
    int[,] array = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[i, j] = matrix[i, j]*matrix2[i, j];
        }
    }
    return array;
}
const int ROWS = 2;
const int COLUMNS = 2;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
int[,] array2 = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
Console.WriteLine();
PrintMatrix(array2);
int[,] arrayMulti = MatrixMultiplication(array,array2);
Console.WriteLine();
PrintMatrix(arrayMulti);
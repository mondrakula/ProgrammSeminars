// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
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

// void Count(int[,] matrix)
// {
//     for(int temp=0; temp<10; temp++)
//     {
//         int count = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if(matrix[i,j]==temp)
//                 {
//                     count++;
//                 }
//             }
//         }
//         Console.WriteLine($"{temp} встречается {count} раз");
//     }
// }

void Count2(int[,] matrix)
{
    int[] counters= new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int index = matrix[i,j];
                counters[index]++;
            }
        }
        for(int i=0; i<counters.Length;i++)
        {
            Console.WriteLine($"Элемент {i} встречается {counters[i]} раз");
        }
}
const int ROWS = 4;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
Count2(array);
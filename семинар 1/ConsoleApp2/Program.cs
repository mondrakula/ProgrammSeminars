void FillArray(int[] collection)
{
    int index = 0;
    int length = collection.Length;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int ind = 0;
    int leng = col.Length;
    while (ind < leng)
    {
        Console.Write($"{col[ind]} ");
        ind++;
    }
}

int IndexOf(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int position = 0;
    while (index < length)
    {
        if (collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
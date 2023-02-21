int[,] RandomFillArray()
{
    int[,] Array = new int[4, 4];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(10);
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
    return Array;
}

int[,] LessOrder(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if (Array[i, k] < Array[i, k + 1])
                {
                    int temporary = Array[i, k + 1];
                    Array[i, k + 1] = Array[i, k];
                    Array[i, k] = temporary;
                }
            }
        }
    }
    return Array;
}



void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Array = LessOrder(RandomFillArray());
Console.WriteLine();
PrintArray(Array);
int[,] RandomFillArray()
{
    int[,] Array = new int[4,3];

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


void FindMinSumRow(int[,] Array)
{
    int[] sumArray = new int[Array.GetLength(0)];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sum = sum + Array[i,j];
        }
        Console.WriteLine($"{sum} ");
        sumArray[i] = sum;
    }
    // С помощью встроенной команды:
    // int minRow = sumArray.Min();

    // "Ручной" способ:
    int minRow = sumArray[0];
    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sumArray[i] < minRow) minRow = sumArray[i];
    }
    Console.WriteLine(minRow);
}

FindMinSumRow(RandomFillArray());
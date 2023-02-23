int[,] Array = new int[4, 4];
int addition = 1;

for (int i = 0, j = 0; j < Array.GetLength(1); j++)
{
    Array[i, j] = addition;
    addition++;
}

for (int i = 1, j = Array.GetLength(1) - 1; i < Array.GetLength(0); i++)
{
    Array[i, j] = addition;
    addition++;
}

for (int i = Array.GetLength(0) - 1, j = Array.GetLength(1) - 2; j >= 0; j--)
{
    Array[i, j] = addition;
    addition++;
}

for (int i = Array.GetLength(0) - 2, j = 0; i > 0; i--)
{
    Array[i, j] = addition;
    addition++;
}

for (int i = 1, j = 1; j <= Array.GetLength(1) - 2; j++)
{
    Array[i, j] = addition;
    addition++;
}

for (int i = Array.GetLength(0) - 2, j = Array.GetLength(1) - 2; i <= Array.GetLength(1) - 2; i++)
{
    Array[i, j] = addition;
    addition++;
}

for (int i = Array.GetLength(0) - 2, j = Array.GetLength(1) - 3; j != Array.GetLength(1) - 2; j++)
{
    Array[i, j] = addition;
}

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        if (Array[i, j] < 10)
        {
            Console.Write($"{0}{Array[i, j]} ");
        }
        else Console.Write($"{Array[i, j]} ");
    }
    Console.WriteLine();
}
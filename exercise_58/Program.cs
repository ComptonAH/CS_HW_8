int[,] FillAndCreateRandomArray()
{
    Console.WriteLine("enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] Array = new int[rows, columns];

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 6);
        }
    }
    return Array;
}

int[,] MatrixMultiplication(int[,] Array1, int[,] Array2)
{
    int[,] MultiplicatedMatrix = new int[Array1.GetLength(0), Array2.GetLength(1)];
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int k = 0; k < Array2.GetLength(1); k++)
        {
            int element = 0;
            for (int j = 0; j < Array1.GetLength(1); j++)
            {
                int Multiplication = Array1[i, j] * Array2[j, k];
                element += Multiplication;
            }
            MultiplicatedMatrix[i, k] = element;
        }
    }
    return MultiplicatedMatrix;
}
Console.Write("For the first matrix ");
int[,] firstArray = FillAndCreateRandomArray();
Console.Write("For the second matrix ");
int[,] secondArray = FillAndCreateRandomArray();

if (firstArray.GetLength(1) == secondArray.GetLength(0))
{
    int[,] MultiplicatedMatrix = MatrixMultiplication(firstArray, secondArray);
    for (int i = 0; i < MultiplicatedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < MultiplicatedMatrix.GetLength(1); j++)
        {
            Console.Write($"{MultiplicatedMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("The rows of the first matrix and the columns of the second matrix must be the same length");
}

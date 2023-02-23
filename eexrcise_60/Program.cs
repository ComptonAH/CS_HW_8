void PrintMultiArray(int[] Array)
{
    int[,,] MultiArray = new int[2, 2, 2];

    int[] temp = new int[8];
    for (int i = 0; i < MultiArray.GetLength(0); i++)
    {
        for (int j = 0; j < MultiArray.GetLength(1); j++)
        {
            for (int k = 0; k < MultiArray.GetLength(2); k++)
            {
                MultiArray[i, j, k] = Convert.ToInt32(Array.GetValue(new Random().Next(1, 90)));
                Console.Write($"{MultiArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


var random = new Random().Next(10, 100);
var intArray = Enumerable.Range(10, 90).OrderBy(t => random).ToArray();
PrintMultiArray(intArray);
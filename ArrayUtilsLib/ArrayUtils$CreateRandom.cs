namespace ArrayUtilsLib;

public partial class ArrayUtils
{
    private static readonly Random random = new(DateTimeOffset.Now.Millisecond);

    public static int[] CreateRandomArray(int a = 10, int b = 1000)
    {
        if (a < 2 || b < 2)
            throw new Exception("a and b must be >= 2");

        var array = new int[random.Next(1, a)];
        for (int index = 0; index < array.Length; index++)
            array[index] = random.Next(1, b);

        return array;
    }

    public static int[,] CreateRandomTable(int a = 10, int b = 1000)
    {
        if (a < 2 || b < 2)
            throw new Exception("a and b must be >= 2");

        int[,] table = new int[random.Next(1, a), random.Next(1, a)];
        for (int rowIndex = 0; rowIndex < table.GetLength(0); rowIndex++)
            for (int columnIndex = 0; columnIndex < table.GetLength(1); columnIndex++)
                table[rowIndex, columnIndex] = random.Next(1, b);

        return table;
    }

    public static int[][] CreateRandomJagArray(int a = 10, int b = 1000)
    {
        if (a < 2 || b < 2)
            throw new Exception("a and b must be >= 2");

        var jagArray = new int[random.Next(1, a)][];
        for (int rowIndex = 0; rowIndex < jagArray.Length; rowIndex++)
        {
            jagArray[rowIndex] = new int[random.Next(1, a)];
            for (int columnIndex = 0; columnIndex < jagArray[rowIndex].Length; columnIndex++)
                jagArray[rowIndex][columnIndex] = random.Next(1, b);
        }

        return jagArray;
    }
}

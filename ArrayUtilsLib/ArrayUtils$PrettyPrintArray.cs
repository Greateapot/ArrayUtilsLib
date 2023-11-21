namespace ArrayUtilsLib;

public partial class ArrayUtils
{
    public static void PrettyPrintArray<T>(T[] array, string? message = null)
    {
        if (array.Length == 0)
        {
            ConsoleIO.WriteLine($"{message}Массив пуст");
        }
        else
        {
            ConsoleIO.WriteLine($"{message}{typeof(T).Name}[{array.Length}] {{ {string.Join(", ", array)} }}");
        }
    }

    public static void PrettyPrintArray<T>(T[,] array, string? message = null)
    {
        if (array.GetLength(0) == 0)
        {
            ConsoleIO.WriteLine($"{message}Массив пуст");
        }
        else
        {
            var parsedRows = new string[array.GetLength(0)];

            for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
            {
                var subArray = new T[array.GetLength(1)];
                for (int columnIndex = 0; columnIndex < array.GetLength(1); columnIndex++)
                    subArray[columnIndex] = array[rowIndex, columnIndex];
                parsedRows[rowIndex] = $"{{ {string.Join(", ", subArray)} }}";
            }

            ConsoleIO.WriteLine(
                $"{message}{typeof(T).Name}[{array.GetLength(0)}, "
                + $"{array.GetLength(1)}] {{\n\t{string.Join(",\n\t", parsedRows)}\n}}"
            );
        }
    }

    public static void PrettyPrintArray<T>(T[][] array, string? message = null)
    {
        if (array.Length == 0)
        {
            ConsoleIO.WriteLine($"{message}Массив пуст");
        }
        else
        {
            var typename = typeof(T).Name;
            var parsedRows = new string[array.Length];

            for (int rowIndex = 0; rowIndex < array.Length; rowIndex++)
                parsedRows[rowIndex] = $"{typename}[{array[rowIndex].Length}] {{ {string.Join(", ", array[rowIndex])} }}";

            ConsoleIO.WriteLine(
                $"{message}{typename}[{array.Length}][] {{\n\t{string.Join(",\n\t", parsedRows)}\n}}"
            );
        }
    }
}

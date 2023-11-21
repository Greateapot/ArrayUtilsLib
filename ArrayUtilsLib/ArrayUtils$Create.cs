namespace ArrayUtilsLib;

public partial class ArrayUtils
{

    public static T[] CreateArray<T>() where T : new()
    {
        var length = ConsoleIO.Input<uint>("Введите кол-во элементов: ");
        var array = new T[length];

        for (int index = 0; index < length; index++)
            array[index] = ConsoleIO.Input<T>($"Введите {index + 1}-й элемент: ");

        return array;
    }

    public static T[,] CreateTable<T>() where T : new()
    {
        var rows = ConsoleIO.Input<uint>("Введите кол-во строк: ");
        var columns = ConsoleIO.Input<uint>("Введите кол-во столбцов: ");
        var table = new T[rows, columns];

        for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            for (int columnIndex = 0; columnIndex < columns; columnIndex++)
                table[rowIndex, columnIndex] = ConsoleIO.Input<T>(
                    $"Введите {columnIndex + 1}-й элемент {rowIndex + 1}-й строки: ");

        return table;
    }

    public static T[][] CreateJagArray<T>() where T : new()
    {
        var rows = ConsoleIO.Input<uint>("Введите кол-во строк: ");
        var jagArray = new T[rows][];

        for (int rowIndex = 0; rowIndex < rows; rowIndex++)
        {
            var columns = ConsoleIO.Input<uint>($"Введите кол-во элементов {rowIndex + 1}-й строки: ");
            jagArray[rowIndex] = new T[columns];
            for (int columnIndex = 0; columnIndex < columns; columnIndex++)
                jagArray[rowIndex][columnIndex] = ConsoleIO.Input<T>(
                        $"Введите {columnIndex + 1} элемент {rowIndex + 1}-й строки: ");
        }

        return jagArray;
    }
}

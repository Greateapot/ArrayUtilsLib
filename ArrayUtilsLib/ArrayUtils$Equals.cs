namespace ArrayUtilsLib
{
    public partial class ArrayUtils
    {
        public static bool Equals<T>(T[] arr1, T[] arr2) where T : IComparable<T>
        {
            bool equals = arr1.Length == arr2.Length;
            for (int index = 0; equals && index < arr1.Length; index++)
                equals = arr1[index].CompareTo(arr2[index]) == 0;
            return equals;
        }

        public static bool Equals<T>(T[,] arr1, T[,] arr2) where T : IComparable<T>
        {
            bool equals = arr1.GetLength(0) == arr2.GetLength(0) && arr1.GetLength(1) == arr2.GetLength(1);
            for (int rowIndex = 0; equals && rowIndex < arr1.GetLength(0); rowIndex++)
                for (int columnIndex = 0; equals && columnIndex < arr1.GetLength(1); columnIndex++)
                    equals = arr1[rowIndex, columnIndex].CompareTo(arr2[rowIndex, columnIndex]) == 0;
            return equals;
        }

        public static bool Equals<T>(T[][] arr1, T[][] arr2) where T : IComparable<T>
        {
            bool equals = arr1.Length == arr2.Length;
            for (int rowIndex = 0; equals && rowIndex < arr1.Length; rowIndex++)
            {
                equals = arr1[rowIndex].Length == arr2[rowIndex].Length;
                for (int columnIndex = 0; equals && columnIndex < arr1[rowIndex].Length; columnIndex++)
                    equals = arr1[rowIndex][columnIndex].CompareTo(arr2[rowIndex][columnIndex]) == 0;
            }
            return equals;
        }
    }
}
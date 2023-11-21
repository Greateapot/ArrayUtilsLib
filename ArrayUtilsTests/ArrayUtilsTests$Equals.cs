namespace ArrayUtilsTests
{
        public partial class ArrayUtilsTest
    {
        [Fact(Timeout = 5)]
        public void TestEqualsArray()
        {
            // arrange
            var array = new int[] { 1, 2, 3, 4 };
            var expectedSlice = new int[] { 3, 4 };
            var slice = array[2..];

            // act
            var result1 = ArrayUtils.Equals(slice, expectedSlice);
            var result2 = ArrayUtils.Equals(slice, new int[] { 2 });
            var result3 = ArrayUtils.Equals(slice, new int[] { 2, 3 });

            // assert
            Assert.True(result1, "Массив должен быть эквивалентен ожидаемому массиву.");
            Assert.False(result2, "Не соотв. по длине.");
            Assert.False(result3, "Не соотв. по элем..");
        }

        [Fact(Timeout = 5)]
        public void TestEqualsTable()
        {
            // arrange
            var table = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            var expectedSlice = new int[1, 2] { { 3, 4 } };

            // var slice = table[1,..]; // Неувязочка вышла. И че делать?
            var slice = new int[1, 2];
            for (int rowIndex = 1; rowIndex < table.GetLength(0); rowIndex++)
                for (int columnIndex = 0; columnIndex < table.GetLength(1); columnIndex++)
                    slice[rowIndex - 1, columnIndex] = table[rowIndex, columnIndex];

            // act
            var result1 = ArrayUtils.Equals(slice, expectedSlice);
            var result2 = ArrayUtils.Equals(slice, new int[1, 1] { { 4 } });
            var result3 = ArrayUtils.Equals(slice, new int[1, 2] { { 4, 3 } });

            // assert
            Assert.True(result1, "Матрица должна быть эквивалентна ожидаемой матрице.");
            Assert.False(result2, "Не соотв. по длине.");
            Assert.False(result3, "Не соотв. по элем..");
        }

        [Fact(Timeout = 5)]
        public void TestEqualsJagArray()
        {
            // arrange
            var array = new int[] { 1, 2, 3, 4 };
            var jagArray = new int[][] { array, new int[] { 1, 2, 2 } };
            var expectedSlice = new int[][] { array };
            var slice = jagArray[..1];

            // act
            var result1 = ArrayUtils.Equals(slice, expectedSlice);
            var result2 = ArrayUtils.Equals(slice, new int[][] { new int[] { 4, 6 }, new int[] { 1, 3, 2 } });
            var result3 = ArrayUtils.Equals(slice, new int[][] { new int[] { 1, 2, 3 } });
            var result4 = ArrayUtils.Equals(slice, new int[][] { new int[] { 1, 2, 3, 5 } });

            // assert
            Assert.True(result1, "Рваный массив должен быть эквивалентен ожидаемому рваному массиву.");
            Assert.False(result2, "Не соотв. по длине (1).");
            Assert.False(result3, "Не соотв. по длине (2).");
            Assert.False(result4, "Не соотв. по элем..");
        }
    }
}

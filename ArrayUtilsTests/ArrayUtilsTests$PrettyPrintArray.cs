namespace ArrayUtilsTests
{
    public partial class ArrayUtilsTest
    {
        [Fact(Timeout = 5)]
        public void TestPrettyPrintArray()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var array = new int[] { 14, 5, 1, 5 };

            // act
            ArrayUtils.PrettyPrintArray(array, "Array: ");
            var result = TestableConsoleIO.MatchOutput(consoleIO.Output ?? "", "Array: ", "$") == "Int32[4] { 14, 5, 1, 5 }";

            // assert
            Assert.True(result, "Вывод должен быть эквивалентен ожидаемому выводу.");
        }

        [Fact(Timeout = 5)]
        public void TestPrettyPrintTable()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var array = new int[2, 3] { { 14, 5, 1 }, { 2, 4, 2 } };

            // act
            ArrayUtils.PrettyPrintArray(array, "Table: ");
            consoleIO.WriteLine(null); // double \n
            var result = TestableConsoleIO.MatchOutput(consoleIO.Output ?? "", "Table: ", "\n\n")
                 == "Int32[2, 3] {\n\t{ 14, 5, 1 },\n\t{ 2, 4, 2 }\n}";

            // assert
            Assert.True(result, "Вывод должен быть эквивалентен ожидаемому выводу.");
        }

        [Fact(Timeout = 5)]
        public void TestPrettyPrintJagArray()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var array = new int[2][] { new int[1] { 3 }, new int[3] { 4, 5, 6 } };

            // act
            ArrayUtils.PrettyPrintArray(array, "jagArray: ");
            consoleIO.WriteLine(null); // double \n
            var result = TestableConsoleIO.MatchOutput(consoleIO.Output ?? "", "jagArray: ", "\n\n")
                == "Int32[2][] {\n\tInt32[1] { 3 },\n\tInt32[3] { 4, 5, 6 }\n}";

            // assert
            Assert.True(result, "Вывод должен быть эквивалентен ожидаемому выводу.");
        }

        [Fact(Timeout = 5)]
        public void TestPrettyPrintEmptyArray()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var array = Array.Empty<int>();

            // act
            ArrayUtils.PrettyPrintArray(array, "Array: ");
            var result = TestableConsoleIO.MatchOutput(consoleIO.Output ?? "", "Array: ", "$") == "Массив пуст";

            // assert
            Assert.True(result, "Вывод должен быть эквивалентен ожидаемому выводу.");
        }

        [Fact(Timeout = 5)]
        public void TestPrettyPrintEmptyTable()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var array = new int[0, 0] { };

            // act
            ArrayUtils.PrettyPrintArray(array, "Table: ");
            consoleIO.WriteLine(null); // double \n
            var result = TestableConsoleIO.MatchOutput(consoleIO.Output ?? "", "Table: ", "\n\n")
                 == "Массив пуст";

            // assert
            Assert.True(result, "Вывод должен быть эквивалентен ожидаемому выводу.");
        }

        [Fact(Timeout = 5)]
        public void TestPrettyPrintEmptyJagArray()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var array = Array.Empty<int[]>();

            // act
            ArrayUtils.PrettyPrintArray(array, "jagArray: ");
            consoleIO.WriteLine(null); // double \n
            var result = TestableConsoleIO.MatchOutput(consoleIO.Output ?? "", "jagArray: ", "\n\n")
                == "Массив пуст";

            // assert
            Assert.True(result, "Вывод должен быть эквивалентен ожидаемому выводу.");
        }
    }
}
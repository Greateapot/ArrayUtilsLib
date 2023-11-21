namespace ArrayUtilsTests
{
    public partial class ArrayUtilsTest
    {
        [Fact(Timeout = 5)]
        public void TestCreateArray()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var expectedArray = new int[] { 1, 2, 4 };

            /// input length -> input elements
            consoleIO.PushLine("3", "1", "2", "4");

            // act
            var array = ArrayUtils.CreateArray<int>();

            // assert
            Assert.True(
                ArrayUtils.Equals(array, expectedArray),
                "Массив должен иметь длину 3 элемента, элем. соотв.: 1; 2; 4."
            );
        }

        [Fact(Timeout = 5)]
        public void TestCreateTable()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var expectedTable = new uint[2, 1] { { 3 }, { 5 } };

            /// input dims -> input elements; -1 element trig if !isValid statement
            consoleIO.PushLine("2", "1", "3", "-1", "5");

            // act
            var table = ArrayUtils.CreateTable<uint>();

            // assert
            Assert.True(
                ArrayUtils.Equals(table, expectedTable),
                "Матрица должна иметь длину 2*1 элемента, элем. соотв.: 3; 5."
            );
        }

        [Fact(Timeout = 5)]
        public void TestCreatejagArray()
        {
            // arrange
            var consoleIO = new TestableConsoleIO();
            var expectedJagArray = new double[][] { new double[] { 3 }, new double[] { 4, .5 } };

            /// input length -> input length + input elements; x2
            consoleIO.PushLine("2", "1", "3", "2", "4", ",5");

            // act
            var jagArray = ArrayUtils.CreateJagArray<double>();

            // assert
            Assert.True(
                ArrayUtils.Equals(jagArray, expectedJagArray),
                "Массив должен иметь длину 2*(1+2) элемента, элем. соотв.: 3; 4; 0,5."
            );
        }
    }
}

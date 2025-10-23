using MatrixLibrary;

namespace MatrixTests
{
    [TestClass]
    public sealed class Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ShouldThrow_WhenNullPassed()
        {
            var m = new Matrix(null, null);
        }

        [TestMethod]
        public void Constructor_ShouldSetDimensionsCorrectly()
        {
            int[,] arr = { { 1, 2 }, { 3, 4 } };
            var m = new Matrix(arr, "A");

            Assert.AreEqual(2, m.CountRows);
            Assert.AreEqual(2, m.CountColumns);
        }

        [TestMethod]
        public void Indexer_ShouldGetAndSetValues()
        {
            int[,] arr = { { 1, 2 }, { 3, 4 } };
            var m = new Matrix(arr, "A");

            Assert.AreEqual(3, m[1, 0]);
            m[1, 0] = 99;
            Assert.AreEqual(99, m[1, 0]);
        }

        [TestMethod]
        public void OperatorPlus_ShouldAddMatrices()
        {
            int[,] aArr = { { 1, 2 }, { 3, 4 } };
            int[,] bArr = { { 5, 6 }, { 7, 8 } };
            var a = new Matrix(aArr, "A");
            var b = new Matrix(bArr, "B");

            var result = a + b;

            Assert.AreEqual(6, result[0, 0]);
            Assert.AreEqual(12, result[1, 1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OperatorPlus_ShouldThrow_WhenDifferentDimensions()
        {
            var a = new Matrix(new int[,] { { 1, 2 } }, "A");
            var b = new Matrix(new int[,] { { 3, 4 }, { 5, 6 } }, "B");

            var res = a + b;
        }

        [TestMethod]
        public void ProductOfNegatives_ShouldReturnCorrectProduct()
        {
            int[,] arr = { { -1, 2 }, { -3, 4 } };
            var m = new Matrix(arr, "A");

            long product = m.MulOfNegatives();

            Assert.AreEqual(3, product);  
        }

        [TestMethod]
        public void ProductOfNegatives_ShouldReturnZero_WhenNoNegatives()
        {
            int[,] arr = { { 1, 2 }, { 3, 4 } };
            var m = new Matrix(arr, "A");

            Assert.AreEqual(0, m.MulOfNegatives());
        }

        [TestMethod]
        public void IncreaseNegatives_ShouldIncreaseOnlyNegatives()
        {
            int[,] arr = { { -5, 2 }, { -3, -1 } };
            var m = new Matrix(arr, "A");

            m.IncreaseNegatives(2);

            Assert.AreEqual(-3, m[0, 0]);
            Assert.AreEqual(2, m[0, 1]);
            Assert.AreEqual(-1, m[1, 0]);
            Assert.AreEqual(1, m[1, 1]);
        }

        [TestMethod]
        public void MinLastRow_ShouldReturnMinimumValueInLastRow()
        {
            int[,] arr = { { 5, 6 }, { 7, 2 }, { 9, -1 } };
            var m = new Matrix(arr, "A");

            Assert.AreEqual(-1, m.MinLastRow());
        }

        [TestMethod]
        public void OperatorTrueFalse_ShouldBehaveCorrectly()
        {
            var nonZero = new Matrix(new int[,] { { 1, 0 } }, "A");
            var zero = new Matrix(new int[,] { { 0, 0 } }, "B");

            if (nonZero)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail("Expected nonZero matrix to evaluate true");
            }

            if (zero)
            {
                Assert.Fail("Expected zero matrix to evaluate false");
            }
            else
            {
                Assert.IsTrue(true);
            }
        }
    }
}

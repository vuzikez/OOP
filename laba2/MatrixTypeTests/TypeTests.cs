using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixType;
using System;

namespace MatrixTests
{
    [TestClass]
    public class MatrixUnitTests
    {
        // Проверка конструктора
        [TestMethod]
        public void Constructor_ShouldCreateMatrix()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            Assert.AreEqual(2, m.CountRows);
            Assert.AreEqual(2, m.CountCols);
        }

        // Проверка индексатора get и set
        [TestMethod]
        public void Indexer_GetAndSet_ShouldWorkCorrectly()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            Assert.AreEqual(3, m[1, 0]);
            m[1, 0] = 10;
            Assert.AreEqual(10, m[1, 0]);
        }

        // Умножение матрицы на число справа
        [TestMethod]
        public void MultiplyByNumber_ShouldScaleMatrix()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            Matrix result = m * 2;
            Assert.AreEqual(2, result[0, 0]);
            Assert.AreEqual(8, result[1, 1]);
        }

        // Умножение матрицы на число слева
        [TestMethod]
        public void MultiplyNumberByMatrix_ShouldScaleMatrix()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            Matrix result = 2 * m;
            Assert.AreEqual(2, result[0, 0]);
            Assert.AreEqual(8, result[1, 1]);
        }

        // Умножение матрицы на матрицу
        [TestMethod]
        public void MultiplyMatrixByMatrix_ShouldReturnCorrectResult()
        {
            double[,] a = { { 1, 2 }, { 3, 4 } };
            double[,] b = { { 2, 0 }, { 1, 2 } };
            Matrix A = new Matrix(a);
            Matrix B = new Matrix(b);
            Matrix result = A * B;
            Assert.AreEqual(4, result[0, 0]);
            Assert.AreEqual(4, result[0, 1]);
            Assert.AreEqual(10, result[1, 0]);
            Assert.AreEqual(8, result[1, 1]);
        }

        // Ошибка при умножении несовместимых матриц
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MultiplyMatrixByMatrix_ShouldThrow_WhenIncompatible()
        {
            double[,] a = { { 1, 2 } };
            double[,] b = { { 1, 2 } };
            Matrix A = new Matrix(a);
            Matrix B = new Matrix(b);
            _ = A * B;
        }

        // Ошибка при создании матрицы из null
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Constructor_ShouldThrow_WhenNullArray()
        {
            Matrix m = new Matrix(null);
        }

        // Умножение на единичную матрицу
        [TestMethod]
        public void MultiplyIdentityMatrix_ShouldReturnSameMatrix()
        {
            double[,] data = { { 5, 7 }, { 1, 2 } };
            Matrix m = new Matrix(data);
            double[,] identity = { { 1, 0 }, { 0, 1 } };
            Matrix I = new Matrix(identity);
            Matrix result = m * I;
            Assert.AreEqual(5, result[0, 0]);
            Assert.AreEqual(7, result[0, 1]);
            Assert.AreEqual(1, result[1, 0]);
            Assert.AreEqual(2, result[1, 1]);
        }

        // Умножение на нулевую матрицу
        [TestMethod]
        public void MultiplyZeroMatrix_ShouldReturnZeroMatrix()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            double[,] zeros = { { 0, 0 }, { 0, 0 } };
            Matrix Z = new Matrix(zeros);
            Matrix result = m * Z;
            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(0, result[1, 1]);
        }

        // Умножение на ноль
        [TestMethod]
        public void MultiplyByZeroScalar_ShouldReturnZeroMatrix()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            Matrix result = m * 0;
            Assert.AreEqual(0, result[0, 0]);
            Assert.AreEqual(0, result[1, 1]);
        }

        // Умножение на единицу
        [TestMethod]
        public void MultiplyByOneScalar_ShouldReturnSameMatrix()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            Matrix result = m * 1;
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(4, result[1, 1]);
        }

        // Умножение 3x2 на 2x3
        [TestMethod]
        public void MultiplyMatrix3x2By2x3_ShouldWork()
        {
            double[,] a = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            double[,] b = { { 7, 8, 9 }, { 10, 11, 12 } };
            Matrix A = new Matrix(a);
            Matrix B = new Matrix(b);
            Matrix result = A * B;
            Assert.AreEqual(27, result[0, 0]);
            Assert.AreEqual(30, result[0, 1]);
            Assert.AreEqual(33, result[0, 2]);
            Assert.AreEqual(95, result[2, 0]);
        }

        // Умножение на большое число
        [TestMethod]
        public void LargeScalarMultiplication_ShouldWork()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            Matrix result = m * 1000;
            Assert.AreEqual(1000, result[0, 0]);
            Assert.AreEqual(4000, result[1, 1]);
        }

        // Умножение на отрицательное число
        [TestMethod]
        public void NegativeScalarMultiplication_ShouldWork()
        {
            double[,] data = { { 1, -2 }, { -3, 4 } };
            Matrix m = new Matrix(data);
            Matrix result = m * -1;
            Assert.AreEqual(-1, result[0, 0]);
            Assert.AreEqual(-4, result[1, 1]);
        }

        // Умножение матрицы на саму себя
        [TestMethod]
        public void MultiplyMatrixByItself_ShouldReturnCorrectResult()
        {
            double[,] data = { { 1, 2 }, { 3, 4 } };
            Matrix m = new Matrix(data);
            Matrix result = m * m;
            Assert.AreEqual(7, result[0, 0]);
            Assert.AreEqual(10, result[0, 1]);
            Assert.AreEqual(15, result[1, 0]);
            Assert.AreEqual(22, result[1, 1]);
        }
    }
}

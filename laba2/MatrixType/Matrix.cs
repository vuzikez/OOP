using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixType
{
    /// <summary>
    /// Представляет двумерную матрицу и поддерживает операции умножения
    /// матриц и умножения матрицы на число
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Двумерный массив, в котором хранятся элементы матрицы
        /// </summary>
        private double[,] _matrix;

        /// <summary>
        /// Количество строк в матрице
        /// </summary>
        private readonly int rowCount;

        /// <summary>
        /// Количество столбцов в матрице
        /// </summary>
        private readonly int colCount;

        /// <summary>
        /// Создаёт экземпляр матрицы на основе двумерного массива
        /// </summary>
        /// <param name="matrix">Двумерный массив элементов</param>
        /// <exception cref="Exception">Бросается, если переданный массив равен null</exception>
        public Matrix(double[,] matrix)
        {
            if (matrix == null)
                throw new Exception("Matrix is null!");

            _matrix = matrix;
            rowCount = matrix.GetUpperBound(0) + 1;
            colCount = matrix.Length / rowCount;
        }

        /// <summary>
        /// Возвращает количество столбцов в матрице
        /// </summary>
        public int CountCols
        {
            get => colCount;
        }

        /// <summary>
        /// Возвращает количество строк в матрице
        /// </summary>
        public int CountRows
        {
            get => rowCount;
        }

        /// <summary>
        /// Индексатор для доступа к элементам матрицы по строке и столбцу
        /// </summary>
        /// <param name="row">Индекс строки</param>
        /// <param name="col">Индекс столбца</param>
        /// <returns>Элемент матрицы в позиции [row, col]</returns>
        public double this[int row, int col]
        {
            get => _matrix[row, col];
            set => _matrix[row, col] = value;
        }

        /// <summary>
        /// Умножает одну матрицу на другую
        /// </summary>
        /// <param name="a">Первая матрица</param>
        /// <param name="b">Вторая матрица</param>
        /// <returns>Новая матрица — результат умножения</returns>
        /// <exception cref="Exception">Бросается, если матрицы несовместимы по размерности</exception>
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a is null || b is null || a.colCount != b.rowCount)
                throw new Exception("Нельзя умножить: кол-во столбцов первой матрицы не равно кол-ву строк второй.");

            double[,] result = new double[a.rowCount, b.colCount];

            for (int i = 0; i < a.rowCount; i++)
            {
                for (int j = 0; j < b.colCount; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < a.colCount; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return new Matrix(result);
        }

        /// <summary>
        /// Умножает матрицу на число
        /// </summary>
        /// <param name="matrix">Исходная матрица</param>
        /// <param name="number">Число</param>
        /// <returns>Новая матрица — результат умножения</returns>
        public static Matrix operator *(Matrix matrix, double number)
        {
            double[,] result = new double[matrix.rowCount, matrix.colCount];
            for (int i = 0; i < matrix.rowCount; i++)
            {
                for (int j = 0; j < matrix.colCount; j++)
                {
                    result[i, j] = matrix[i, j] * number;
                }
            }
            return new Matrix(result);
        }

        /// <summary>
        /// Умножает число на матрицу
        /// </summary>
        /// <param name="number">Число</param>
        /// <param name="matrix">Матрица</param>
        /// <returns>Новая матрица — результат умножения</returns>
        public static Matrix operator *(double number, Matrix matrix) => matrix * number;
    }
}

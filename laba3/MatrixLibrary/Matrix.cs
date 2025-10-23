namespace MatrixLibrary
{
    /// <summary>
    /// Класс, представляющий матрицу и операции над ней.
    /// </summary>
    public class Matrix
    {
        private int[,] _matrix;
        private string _nameMatrix;

        /// <summary>
        /// Количество строк в матрице.
        /// </summary>
        public int CountRows { get; }

        /// <summary>
        /// Количество столбцов в матрице.
        /// </summary>
        public int CountColumns { get; }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Matrix"/>.
        /// </summary>
        /// <param name="matrix">Двумерный массив значений матрицы.</param>
        /// <param name="nameMatrix">Имя матрицы.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если <paramref name="matrix"/> или <paramref name="nameMatrix"/> равны null.</exception>
        public Matrix(int[,] matrix, string nameMatrix)
        {
            if (matrix is null || nameMatrix is null)
            {
                throw new ArgumentNullException("Matrix is null!");
            }
            _matrix = matrix;
            _nameMatrix = nameMatrix;
            CountRows = matrix.GetLength(0);
            CountColumns = matrix.GetLength(1);
        }

        /// <summary>
        /// Доступ к элементам матрицы по индексу.
        /// </summary>
        /// <param name="row">Номер строки (начиная с 0).</param>
        /// <param name="col">Номер столбца (начиная с 0).</param>
        /// <returns>Значение элемента матрицы.</returns>
        public int this[int row, int col]
        {
            get => _matrix[row, col];
            set => _matrix[row, col] = value;
        }

        /// <summary>
        /// Ввод матрицы с консоли.
        /// </summary>
        /// <returns>Двумерный массив, заполненный значениями из консоли.</returns>
        public int[,] InputMatrix()
        {
            Console.WriteLine("Введите кол-во строк и столбцов матрицы: ");
            int rows = Int32.Parse(Console.ReadLine());
            int columns = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Matrix[{i},{j}] = ");
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        /// <summary>
        /// Вывод матрицы на консоль.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Matrix {_nameMatrix}:");
            for (int i = 0; i < CountRows; i++)
            {
                for (int j = 0; j < CountColumns; j++)
                    Console.Write($"{_matrix[i, j]} ");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Определяет, является ли матрица "истиной" (если есть хотя бы один ненулевой элемент).
        /// </summary>
        /// <param name="m">Матрица для проверки.</param>
        /// <returns><c>true</c>, если хотя бы один элемент матрицы не равен нулю, иначе <c>false</c>.</returns>
        public static bool operator true(Matrix m)
        {
            foreach (int val in m._matrix)
                if (val != 0)
                    return true;
            return false;
        }

        /// <summary>
        /// Определяет, является ли матрица "ложью" (все элементы равны нулю).
        /// </summary>
        /// <param name="m">Матрица для проверки.</param>
        /// <returns><c>true</c>, если все элементы равны нулю, иначе <c>false</c>.</returns>
        public static bool operator false(Matrix m)
        {
            foreach (int val in m._matrix)
                if (val != 0)
                    return false;
            return true;
        }

        /// <summary>
        /// Операция сложения двух матриц одинакового размера.
        /// </summary>
        /// <param name="a">Первая матрица.</param>
        /// <param name="b">Вторая матрица.</param>
        /// <returns>Новая матрица, являющаяся результатом сложения.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если размеры матриц не совпадают.</exception>
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.CountRows != b.CountRows || a.CountColumns != b.CountColumns)
                throw new ArgumentException("Матрицы разной размерности!");

            int[,] result = new int[a.CountRows, a.CountColumns];
            for (int i = 0; i < a.CountRows; i++)
                for (int j = 0; j < a.CountColumns; j++)
                    result[i, j] = a[i, j] + b[i, j];

            return new Matrix(result, a._nameMatrix + "+" + b._nameMatrix);
        }

        /// <summary>
        /// Вычисляет произведение всех отрицательных элементов матрицы.
        /// </summary>
        /// <returns>Произведение отрицательных чисел, либо 0, если их нет.</returns>
        public long MulOfNegatives()
        {
            long product = 1;
            bool found = false;
            foreach (int val in _matrix)
            {
                if (val < 0)
                {
                    product *= val;
                    found = true;
                }
            }
            if (found)
                return product;
            return 0;
        }

        /// <summary>
        /// Вычисляет произведение всех отрицательных элементов матрицы с выводом результата.
        /// </summary>
        /// <param name="matrixName">Имя матрицы для отображения в консоли.</param>
        /// <returns>Произведение отрицательных чисел, либо 0, если их нет.</returns>
        public long MulOfNegatives(string matrixName)
        {
            long result = MulOfNegatives();
            Console.WriteLine($"Произведение отрицательных элементов матрицы {matrixName}: {result}");
            return result;
        }

        /// <summary>
        /// Увеличивает все отрицательные элементы матрицы на указанное значение.
        /// </summary>
        /// <param name="addValue">Значение, на которое увеличиваются отрицательные элементы.</param>
        public void IncreaseNegatives(int addValue)
        {
            for (int i = 0; i < CountRows; i++)
                for (int j = 0; j < CountColumns; j++)
                    if (_matrix[i, j] < 0)
                        _matrix[i, j] += addValue;
        }

        /// <summary>
        /// Возвращает минимальный элемент последней строки матрицы.
        /// </summary>
        /// <returns>Минимальное значение в последней строке.</returns>
        public int MinLastRow()
        {
            int lastRow = CountRows - 1;
            int min = _matrix[lastRow, 0];
            for (int j = 1; j < CountColumns; j++)
                if (_matrix[lastRow, j] < min)
                    min = _matrix[lastRow, j];
            return min;
        }
    }
}
using MatrixType;

namespace MatrixApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Для работы требуется создать матрицы.");
                Console.WriteLine("Матрица А: ");
                Matrix A = CreateMatrix();
                Console.WriteLine("Матрица Б: ");
                Matrix B = CreateMatrix();

                while (true)
                {
                    Console.WriteLine("\n--- Меню ---");
                    Console.WriteLine("1. Показать матрицу A");
                    Console.WriteLine("2. Показать матрицу Б");
                    Console.WriteLine("3. Умножить A на число");
                    Console.WriteLine("4. Умножить A на B");
                    Console.WriteLine("5. Выход");
                    Console.Write("Выберите пункт: ");

                    string? input = Console.ReadLine();
                    if (input is null)
                    {
                        throw new Exception("Ввод пуст!");
                    }
                    Console.WriteLine();
                    switch (input)
                    {
                        case "1":
                            ShowMatrix(A);
                            break;
                        case "2":
                            ShowMatrix(B);
                            break;
                        case "3":
                            Console.WriteLine("Введите число для умножения: ");
                            double number = double.Parse(Console.ReadLine());
                            ShowMatrix(A * number);
                            break;
                        case "4":
                            ShowMatrix(A * B);
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Неверный ввод. Введите от 1 до 5!");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Возникла ошибка: {e.Message}");
            }
        }

        public static Matrix CreateMatrix()
        {
            Console.WriteLine("Введите кол-во строк и столбцов: ");
            int rows = Int32.Parse(Console.ReadLine());
            int cols = Int32.Parse(Console.ReadLine());
            double[,] tempM = new double[rows, cols];
            Console.WriteLine("Введите элементы матрицы: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    tempM[i,j] = double.Parse(Console.ReadLine());
                }
            }
            return new Matrix(tempM);
        }

        public static void ShowMatrix(Matrix matrix)
        {
            for(int i = 0;i<matrix.CountRows;i++)
            {
                for(int j = 0; j<matrix.CountCols;j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

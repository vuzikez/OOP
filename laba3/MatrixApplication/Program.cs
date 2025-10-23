using MatrixLibrary;

namespace MatrixApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите имя матрицы: ");
                string? name1 = Console.ReadLine();
                Matrix A = new Matrix(CreateMatrix(), name1);
                Console.Write("Введите имя матрицы: ");
                string? name2 = Console.ReadLine();
                Matrix B = new Matrix(CreateMatrix(), name2);
                Console.Write("Введите имя матрицы: ");
                string? name3 = Console.ReadLine();
                Matrix C = new Matrix(CreateMatrix(), name3);

                A.Print();
                B.Print();
                C.Print();

                A.MulOfNegatives(name1);
                B.MulOfNegatives(name2);
                C.MulOfNegatives(name3);
                Matrix D = A + B;
                Console.WriteLine("Сумма А+B: ");
                D.Print();

                long prodA = A.MulOfNegatives();
                Console.WriteLine("Задайте число: ");
                double number = Double.Parse(Console.ReadLine());
                if (prodA > number && C.MulOfNegatives() != 0)
                {
                    int minLastRow = C.MinLastRow();
                    A.IncreaseNegatives(minLastRow);
                    Console.WriteLine("\nA после изменения:");
                    A.Print();
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        public static int[,] CreateMatrix()
        {
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] values = new int[rows, cols];

            Console.WriteLine("Введите элементы матрицы построчно:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"[{i},{j}] = ");
                    values[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return values;
        }
    }
}

using FigureLibrary;

namespace CircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point[] points = CreateCirclePoints();
                Circle circle = new Circle(points);
                Console.WriteLine("Окружность создана успешно!");
                while (true)
                {
                    Console.WriteLine("\n=== ГЛАВНОЕ МЕНЮ ===");
                    Console.WriteLine("1. Проверить валидность окружности");
                    Console.WriteLine("2. Вычислить длину окружности");
                    Console.WriteLine("3. Вычислить площадь окружности");
                    Console.WriteLine("4. Проверить точку на границе");
                    Console.WriteLine("5. Проверить точку внутри окружности");
                    Console.WriteLine("6. Выход");
                    Console.Write("Выберите действие: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            if (circle.IsValid())
                                Console.WriteLine("\nОкружность валидна!");
                            else
                                Console.WriteLine("\nОкружность не валдина!");
                            break;
                        case "2":
                            Console.WriteLine($"\nДлина окружности: {circle.GetLength()}");
                            break;

                        case "3":
                            Console.WriteLine($"\nПлощадь окружности: {circle.GetArea()}");
                            break;

                        case "4":
                            Console.WriteLine("Введите точку: ");
                            Point point1 = new Point();
                            point1.x = Double.Parse(Console.ReadLine());
                            point1.y = Double.Parse(Console.ReadLine());
                            if (circle.IsPointOnBorder(point1))
                                Console.WriteLine("\nТочка на границе окружности");
                            else
                                Console.WriteLine("\nТочка не на границе окружности");
                            break;

                        case "5":
                            Console.WriteLine("Введите точку: ");
                            Point point2 = new Point();
                            point2.x = Double.Parse(Console.ReadLine());
                            point2.y = Double.Parse(Console.ReadLine());
                            if (circle.IsPointInFigure(point2))
                                Console.WriteLine("\nТочка в окружности");
                            else
                                Console.WriteLine("\nТочка за окружностью");
                            break;
                        case "6":
                            return;

                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникло исключение: {ex.Message}");
                Console.ReadKey();
            }
        }

        public static Point[] CreateCirclePoints()
        {
            Point[] points = new Point[4];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Точка {i + 1}: ");
                points[i].x = Double.Parse(Console.ReadLine());
                points[i].y = Double.Parse(Console.ReadLine());
            }
            return points;
        }
    }
}

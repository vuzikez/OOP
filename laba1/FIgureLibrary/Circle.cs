using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    /// <summary>
    /// Представляет окружность, описанную вокруг квадрата
    /// Окружность определяется четырьмя точками - вершинами квадрата
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса Circle с указанными точками
        /// </summary>
        /// <param name="points">Массив из четырех точек, представляющих вершины квадрата</param>
        /// <exception cref="ArgumentException">Вызывается, если points равен null или количество точек не равно 4</exception>
        public Circle(Point[] points)
            : base(points)
        {
            if (points == null || points.Length != 4)
            {
                throw new ArgumentException("Задано больше либо меньше 4 точек или points is null");
            }
        }

        /// <summary>
        /// Вычисляет центр окружности
        /// </summary>
        /// <returns>Точка центра окружности</returns>
        public Point GetCenterPoint()
        {
            double centerX = (points[0].x + points[2].x) / 2;
            double centerY = (points[0].y + points[2].y) / 2;
            return new Point(centerX, centerY);
        }

        /// <summary>
        /// Вычисляет радиус окружности
        /// </summary>
        /// <returns>Радиус окружности</returns>
        public double GetRadius() => Distance(points[0], points[1]) / 2;

        /// <summary>
        /// Проверяет, образуют ли точки квадрат
        /// </summary>
        /// <param name="point">Массив точек для проверки</param>
        /// <returns>True, если точки образуют квадрат, иначе False</returns>
        public bool IsSquare(Point[] point)
        {
            const double error = 0.0001;
            double distance1 = Distance(point[0], point[1]);
            double distance2 = Distance(point[1], point[2]);
            double distance3 = Distance(point[2], point[3]);
            double distance4 = Distance(point[3], point[0]);
            return Math.Abs(distance1 - distance2) < error &&
                   Math.Abs(distance2 - distance3) < error &&
                   Math.Abs(distance3 - distance4) < error &&
                   Math.Abs(distance4 - distance1) < error;
        }

        /// <summary>
        /// Вычисляет расстояние между двумя точками
        /// </summary>
        /// <param name="p1">Первая точка</param>
        /// <param name="p2">Вторая точка</param>
        /// <returns>Расстояние между точками.</returns>
        public double Distance(Point p1, Point p2) => Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow(p2.y - p1.y, 2));

        /// <summary>
        /// Проверяет валидность окружности
        /// Окружность считается валидной, если радиус положителен и точки образуют квадрат
        /// </summary>
        /// <returns>True, если окружность валидна, иначе False</returns>
        public override bool IsValid()
        {
            if (GetRadius() > 0 && IsSquare(points))
                return true;
            return false;
        }

        /// <summary>
        /// Вычисляет длину окружности
        /// </summary>
        /// <returns>Длина окружности</returns>
        /// <exception cref="InvalidOperationException">Вызывается, если окружность не валидна</exception>
        public override double GetLength()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Окружность не валидна");
            }
            return 2 * Math.PI * GetRadius();
        }

        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        /// <exception cref="InvalidOperationException">Вызывается, если окружность не валидна</exception>
        public override double GetArea()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Окружность не валидна");
            }
            return Math.PI * Math.Pow(GetRadius(), 2);
        }

        /// <summary>
        /// Проверяет, находится ли точка на границе окружности
        /// </summary>
        /// <param name="point">Точка для проверки</param>
        /// <returns>True, если точка находится на границе окружности; иначе False</returns>
        /// <exception cref="InvalidOperationException">Вызывается, если окружность не валидна</exception>
        public override bool IsPointOnBorder(Point point)
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Окружность не валидна");
            }

            double distance = Distance(GetCenterPoint(), point);
            return Math.Abs(distance - GetRadius()) < 0.1;
        }

        /// <summary>
        /// Проверяет, находится ли точка внутри окружности
        /// </summary>
        /// <param name="point">Точка для проверки.</param>
        /// <returns>True, если точка находится внутри окружности; иначе False</returns>
        /// <exception cref="InvalidOperationException">Вызывается, если окружность не валидна</exception>
        public override bool IsPointInFigure(Point point)
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Окружность не валидна");
            }

            double distance = Distance(GetCenterPoint(), point);
            return distance <= GetRadius();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    /// <summary>
    /// Абстрактный базовый класс для геометрических фигур
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Массив точек, определяющих фигуру
        /// </summary>
        public Point[] points;

        /// <summary>
        /// Инициализирует новый экземпляр класса Figure с указанными точками
        /// </summary>
        /// <param name="points">Массив точек, определяющих фигуру</param>
        public Figure(Point[] points)
        {
            this.points = points;
        }

        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        public abstract double GetArea();

        /// <summary>
        /// Вычисляет периметр или длину фигуры
        /// </summary>
        /// <returns>Периметр или длина фигуры</returns>
        public abstract double GetLength();

        /// <summary>
        /// Проверяет валидность фигуры
        /// </summary>
        /// <returns>True если фигура валидна, иначе False</returns>
        public abstract bool IsValid();

        /// <summary>
        /// Проверяет находится ли точка на границе фигуры
        /// </summary>
        /// <param name="point">Точка для проверки</param>
        /// <returns>True если точка на границе, иначе False</returns>
        public abstract bool IsPointOnBorder(Point point);

        /// <summary>
        /// Проверяет находится ли точка внутри фигуры
        /// </summary>
        /// <param name="point">Точка для проверки</param>
        /// <returns>True если точка внутри фигуры, иначе False</returns>
        public abstract bool IsPointInFigure(Point point);
    }
}

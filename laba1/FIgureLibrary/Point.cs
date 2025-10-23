using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    /// <summary>
    /// Структура, представляющая точку в двумерном пространстве
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Координата X точки
        /// </summary>
        public double x;

        /// <summary>
        /// Координата Y точки
        /// </summary>
        public double y;

        /// <summary>
        /// Инициализирует новый экземпляр структуры Point с указанными координатами
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}

namespace FigureLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Constructor_ValidPoints_CreatesCircle()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(2, 0),
                new Point(2, 2),
                new Point(0, 2)
            };

            Circle circle = new Circle(points);
            Assert.IsNotNull(circle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_InvalidPoints_ThrowsException()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(2, 0),
                new Point(2, 2)
            };

            Circle circle = new Circle(points);
        }

        [TestMethod]
        public void GetRadius_ValidSquare_ReturnsRadius()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(4, 0),
                new Point(4, 4),
                new Point(0, 4)
            };

            Circle circle = new Circle(points);
            double radius = circle.GetRadius();
            Assert.AreEqual(2.0, radius, 0.001);
        }

        [TestMethod]
        public void IsValid_ValidSquare_ReturnsTrue()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(2, 0),
                new Point(2, 2),
                new Point(0, 2)
            };

            Circle circle = new Circle(points);
            bool isValid = circle.IsValid();
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void GetArea_ValidCircle_ReturnsArea()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(2, 0),
                new Point(2, 2),
                new Point(0, 2)
            };

            Circle circle = new Circle(points);
            double area = circle.GetArea();
            double expectedArea = Math.PI * 1 * 1;
            Assert.AreEqual(expectedArea, area, 0.001);
        }

        [TestMethod]
        public void GetLength_ValidCircle_ReturnsLength()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(2, 0),
                new Point(2, 2),
                new Point(0, 2)
            };

            Circle circle = new Circle(points);
            double length = circle.GetLength();
            double expectedLength = 2 * Math.PI * 1;
            Assert.AreEqual(expectedLength, length, 0.001);
        }

        [TestMethod]
        public void IsPointInFigure_PointInside_ReturnsTrue()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(4, 0),
                new Point(4, 4),
                new Point(0, 4)
            };

            Circle circle = new Circle(points);
            Point testPoint = new Point(2, 2);
            bool isInside = circle.IsPointInFigure(testPoint);
            Assert.IsTrue(isInside);
        }

        [TestMethod]
        public void IsPointOnBorder_PointOnBorder_ReturnsTrue()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(4, 0),
                new Point(4, 4),
                new Point(0, 4)
            };

            Circle circle = new Circle(points);
            Point testPoint = new Point(2, 0);
            bool isOnBorder = circle.IsPointOnBorder(testPoint);
            Assert.IsTrue(isOnBorder);
        }

        [TestMethod]
        public void GetCenterPoint_ValidSquare_ReturnsCenter()
        {
            Point[] points = new Point[]
            {
                new Point(1, 1),
                new Point(5, 1),
                new Point(5, 5),
                new Point(1, 5)
            };

            Circle circle = new Circle(points);
            Point center = circle.GetCenterPoint();
            Assert.AreEqual(3, center.x, 0.001);
            Assert.AreEqual(3, center.y, 0.001);
        }
    }
}
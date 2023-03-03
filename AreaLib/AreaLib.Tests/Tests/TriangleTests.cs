using AreaLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Tests.Tests
{
	internal class TriangleTests
	{
        [Test]
        public void Create_WrongTriangle_Throws()
        {
            // ACT + ASSERT
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(-12, 7, 23));
            Assert.Throws<ArgumentException>(() => new Triangle(423, -4, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(43, 43, -42));
        }

        [Test]
        public void Area_Triangle_Double()
        {
            // ARRANGE
            Triangle triangle1 = new Triangle(4, 8, 9);
            Triangle triangle2 = new Triangle(233, 76, 234);
            Triangle triangle3 = new Triangle(54.1, 34.2, 23.3);

            // ACT
            double area1 = Math.Round(triangle1.GetArea());
            double area2 = Math.Round(triangle2.GetArea());
            double area3 = Math.Round(triangle3.GetArea());

            // ASSERT
            Assert.AreEqual(16, area1);
            Assert.AreEqual(8754, area2);
            Assert.AreEqual(258, area3);
        }

        [Test]
        public void Rectangular_Triangle_False()
        {
            // ARRANGE
            Triangle triangle1 = new Triangle(4, 8, 9);
            Triangle triangle2 = new Triangle(233, 76, 234);
            Triangle triangle3 = new Triangle(54.1, 34.2, 23.3);

            // ACT + ASSERT
            Assert.IsFalse(triangle1.IsRectangularTriangle);
            Assert.IsFalse(triangle2.IsRectangularTriangle);
            Assert.IsFalse(triangle3.IsRectangularTriangle);
        }

        [Test]
        public void Rectangular_Triangle_True()
        {
            // ARRANGE
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(9, 40, 41);
            Triangle triangle3 = new Triangle(999, 499000, 499001);

            // ACT + ASSERT
            Assert.IsTrue(triangle1.IsRectangularTriangle);
            Assert.IsTrue(triangle2.IsRectangularTriangle);
            Assert.IsTrue(triangle3.IsRectangularTriangle);
        }
    }
}

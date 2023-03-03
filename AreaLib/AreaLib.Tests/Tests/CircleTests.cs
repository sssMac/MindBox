using AreaLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Tests.Tests
{
	public class CircleTests
	{
        [Test]
        public void Create_WrongCircle_Throws()
        {
            // ACT + ASSERT
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-1));
            Assert.Throws<ArgumentException>(() => new Circle(-0.0000000001));

        }

        [Test]
        public void Area_Circle_Double()
        {
            // ARRANGE
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(765.45);
            Circle circle3 = new Circle(99999.999999);

            // ACT
            double area1 = Math.Round(circle1.GetArea());
            double area2 = Math.Round(circle2.GetArea());
            double area3 = Math.Round(circle3.GetArea());

            // ASSERT
            Assert.AreEqual(79, area1);
            Assert.AreEqual(1840702, area2);
            Assert.AreEqual(31415926535, area3);

        }
    }
}

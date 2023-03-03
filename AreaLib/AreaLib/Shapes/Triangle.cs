using AreaLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Shapes
{
	public class Triangle : IShape
	{
		private const double _THRESHOLD = 0;
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }

		public bool IsRectangularTriangle { get; private set; }

		public Triangle(double sideA, double sideB, double sideC)
		{
			CheckValid(sideA, sideB, sideC);

			var sortedSides = new[] { sideA, sideB, sideC }.OrderBy(x => x).ToArray();
			SideA = sortedSides[0];
			SideB = sortedSides[1];
			SideC = sortedSides[2];

			IsRectangularTriangle = CheckIsRectangularTriangle();
		}

		public double GetArea()
		{
			double semiperimeter = (SideA + SideB + SideC) / 2;
			return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
		}
		private bool CheckIsRectangularTriangle()
		{
			return SideA * SideA + SideB * SideB == SideC * SideC;
		}
		private bool CheckValid(double sideA, double sideB, double sideC)
		{
			if (sideA <= _THRESHOLD || sideB <= _THRESHOLD || sideC <= _THRESHOLD)
			{
				throw new ArgumentException("Parametrs is wrong!");
			}

			var largestSide = Math.Max(sideA, Math.Max(sideB, sideC));
			var perimeter = sideA + sideB + sideC;

			if ((perimeter - largestSide) - largestSide <= _THRESHOLD)
			{
				throw new ArgumentException(
					"One side of a triangle is greater than the sum of the other two sides. Such a triangle cannot exist!");
			}

			return true;
		}
		
	}
}

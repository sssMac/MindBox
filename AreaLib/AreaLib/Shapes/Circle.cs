using AreaLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Shapes
{
	public class Circle : IShape
	{
		private const double _THRESHOLD = 0;
		public double Radius { get; set; }

		public Circle(double radius)
		{
			if(radius <= _THRESHOLD)
			{
				throw new ArgumentException("Radius is wrong!");
			}

			Radius = radius;
		}

		public double GetArea()
		{
			return Math.PI * (Radius * Radius);
		}
	}
}

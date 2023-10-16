using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
	public class Circle
	{
		private const double Pi = 3.142;

		// Constructor
		public Circle(double radius)
		{
			Radius = radius;
		}

		// Property
		public double Radius { get; private set; }


		// Methods
		public double Circumference()
		{
			return 2 * Pi * Radius;
		}

		public double Area()
		{
			return Pi * Math.Pow(Radius, 2);
		}
	}
}

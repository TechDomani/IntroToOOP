using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
	public static class CircleProcedural
	{
		private const double Pi = 3.142;

		public static double CalcArea(double radius)
		{
			return Pi * Math.Pow(radius, 2);
		}

		public static double CalcCircumference(double radius)
		{
			return 2 * Pi * radius;
		}
	}
}

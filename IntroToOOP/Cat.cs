using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
	public class Cat
	{
		public string Name { get; private set; }
		public string Food { get; private set; }

		public Cat(string name, string food)
		{
			Name = name;
			Food = food;
		}

		public string Greet()
		{
			return $"My name is {Name} and I eat {Food}";
		}
	}
}

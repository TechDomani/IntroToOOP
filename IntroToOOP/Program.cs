namespace IntroToOOP
{
	internal class Program
	{
		static void Main()
		{
			// Call cat objects
			Cat cat1 = new ("John", "Applaws");
			Cat cat2 = new ("Garfield", "Lasagna");
			List<Cat> cats = new() {cat1, cat2};
			foreach (Cat cat in cats)
			{
				Console.WriteLine(cat.Greet());
			}
		}
	}
}
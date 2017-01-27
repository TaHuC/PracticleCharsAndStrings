using System;

namespace PracticleCharsAndStrings
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string string1 = Console.ReadLine();
			char char1 = char.Parse(Console.ReadLine());
			char char2 = char.Parse(Console.ReadLine());
			char char3 = char.Parse(Console.ReadLine());
			string string2 = Console.ReadLine();

			Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", string1, char1, char2, char3, string2);
		}
	}
}

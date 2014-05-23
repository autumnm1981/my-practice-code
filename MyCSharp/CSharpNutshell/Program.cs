namespace CSharpNutshell
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using SizeofTest;

	class Program
	{
		static void Main(string[] args)
		{
			//unsafe
			//{
			//	//Console.WriteLine("", sizeof(ClassA));
			//	Console.WriteLine("The size of StructA is: {0}", sizeof(StructA));
			//}
			foobar();

			Console.WriteLine("Press any key to exist...");
			Console.ReadKey();
		}

		static void foobar()
		{
			Console.Write("Press enter a number:");
			string input = Console.ReadLine();
			int num;
			if (int.TryParse(input, out num))
			{
				var test = new StackTest();
				Console.WriteLine("The 8-base number of {0} is: {1}", num, test.ConvertTo8(num));
				if (!exist())
					foobar();
			}
			else
			{
				Console.WriteLine("The input is not a valid number.");
				foobar();
			}
		}

		static bool exist()
		{
			Console.Write("Do you want to exist? (Y/N):");
			string input = Console.ReadLine();
			return string.Equals(input, "y", StringComparison.OrdinalIgnoreCase);
		}
	}
}

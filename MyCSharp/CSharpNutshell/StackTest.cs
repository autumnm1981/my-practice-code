namespace CSharpNutshell
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	class StackTest
	{
		private Stack<int> stack = new Stack<int>();

		public string ConvertTo8(int num)
		{
			string out8 = string.Empty;
			while (num != 0)
			{
				this.stack.Push(num % 8);
				num = num / 8;
			}

			while (this.stack.Count > 0)
			{
				out8 = string.Format("{0}{1}", out8, this.stack.Pop());
			}

			return out8;
		}
	}
}

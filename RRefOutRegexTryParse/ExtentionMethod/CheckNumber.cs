using System;
namespace ExtentionMethod
{
	public static class CheckNumber
	{
		public static void CheckIsGreaterThan(int i, int value)
		{
			if (i > value)
			{
				Console.WriteLine($"{i} lon hon{value}");
			}
		}
	}
}


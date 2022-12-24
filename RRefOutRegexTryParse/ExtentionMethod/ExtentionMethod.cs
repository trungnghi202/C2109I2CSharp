using System;
namespace ExtentionMethod
{
	public static class ExtentionMethod
	{
		public static void CheckIsGreaterThan(this int i, int value)
		{
			if (i > value)
			{
                Console.WriteLine($"{i} lon hon{value}");
            }
		}

		public static void Hello(this Program pro)
		{
			Console.WriteLine("haahah");
		}
	}
	
}


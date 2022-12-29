using System;
namespace OopExercise.ExtentionMethod
{
	static class ExtMethod
	{
		public static void ChangeColor<T>(this T item, params ConsoleColor[] colors)
		{
			Console.BackgroundColor = colors[0];
			Console.ForegroundColor = colors[1];	
		}
	}
}


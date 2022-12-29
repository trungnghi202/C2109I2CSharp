using System;
namespace GenericClass
{
	public class ClassT<T>
	{
		public T Field { get; set; }
		public void show()
		{
			Console.WriteLine($"{nameof(Field)} = {Field}");
		}
	}
}


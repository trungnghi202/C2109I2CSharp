using System;
namespace GenericClass
{
	public class ClassUV<U,V>
	{
		public U Field1 { get; set; }
		public V Field2 { get; set; }
        public void Show() => Console.WriteLine($"{nameof(Field1)} = {Field1},{nameof(Field2)} = {Field2}");
    }
}


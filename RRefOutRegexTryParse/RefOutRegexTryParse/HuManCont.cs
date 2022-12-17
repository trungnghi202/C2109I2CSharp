global using System;
namespace RefOutRegexTryParse
{
	internal partial class Human
	{
		//1 phuong thuc ma chi co 1 cau lenh
		//csharp sẽ không sử dụng phương thức mà dùng
		// expression body => biểu thức dưới dạng phương thức
		public void Show()
		{
			Console.WriteLine($"{nameof(fullname)}={fullname}");
		}
        public void Check() => Console.WriteLine(10 > 5 ? true : false);
    }
}


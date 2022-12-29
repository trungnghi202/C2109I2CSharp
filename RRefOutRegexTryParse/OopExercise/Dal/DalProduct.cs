using System;
using OopExercise.Entity;
using OopExercise.Helper;
using OopExercise.Service;

namespace OopExercise.Dal
{
	public class DalProduct : IProduct 
	{
		public List<Product> list { get; set; } = new();
		public void Add()
		{
			var n = Validate<int>.Input("Please enter number of list");
			for(int i = 0; i < n; i++)
			{
				Product pro = new();
				pro.Id = Validate<string>.Input("Please enter Id:");
                pro.Name = Validate<string>.Input("Please enter Name:");
                pro.Price = Validate<double>.Input("Please enter price:");
                pro.Quantity = Validate<int>.Input("Please enter quantity:");
                pro.Mfg = Validate<DateTime>.Input("Please enter Mfg:");
				list.Add(pro);
            }


		}
		public void Show()
		{
			list.ForEach(Console.WriteLine);
		}
	}
}


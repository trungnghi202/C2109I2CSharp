global using System;
namespace OopExercise.Entity
{
	public class Product
	{
		public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Mfg { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id}, {nameof(Name)}={Name}, {nameof(Price)}={Price.ToString()}, {nameof(Quantity)}={Quantity.ToString()}, {nameof(Mfg)}={Mfg.ToString("dd/MM/yyyy hh:mm:ss")}}}";
        }

    }
}


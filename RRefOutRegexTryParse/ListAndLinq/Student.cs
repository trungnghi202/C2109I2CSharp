global using System;
namespace ListAndLinq
{
	public class Student
	{
		public int Id { get; set; }
		public string Name1 { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob{ get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name1)}={Name1}, {nameof(Gender)}={Gender.ToString()}, {nameof(Dob)}={Dob.ToString()}}}";
        }
    }
}


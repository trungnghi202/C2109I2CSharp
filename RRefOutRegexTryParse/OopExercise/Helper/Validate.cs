using System;
using System.Globalization;

namespace OopExercise.Helper
{
	public class Validate<T>
	{
		public static T Input(string message)
		{
			var typecode = Type.GetTypeCode(typeof(T));
			object obj = new();
			bool flag;
			do
			{
				flag = true;
				var str = Console.ReadLine();
				try
				{
                    if (string.IsNullOrEmpty(str))
                    {
                        throw new Exception("error, null or empti");
                    }
					switch (typecode)
					{
						case TypeCode.String:
							obj = str;
							break;

						case TypeCode.Int32:
							obj = Convert.ToInt32(str);
							if((int)obj < 0)
							{
								throw new Exception("Value must be greater than or equal");
							}
							break;
						case TypeCode.Double:
							obj = Convert.ToDouble(str);
							if((double)obj < 0)
							{
                                throw new Exception("Value must be greater than or equal");
                            }
							break;
						case TypeCode.DateTime:
							var date = DateTime.TryParseExact(str, new[] {"d/M/yyyy","d-M-yyyy" }, new CultureInfo("vi-VN"), DateTimeStyles.None, out var t)?t:throw new
								Exception("datetime wrong (d-M-yyyy or d/M/yyyy )");
							obj = date.Add(DateTime.Now.TimeOfDay);
							break;

					}

                }
				catch (Exception e)
				{
					Console.WriteLine($"{e.GetType} : {e.Message}, enter again");
					flag = false;
				}
				
			} while (!flag);
			return (T)obj;
		}

	}
}


using System;
using OopExercise.Dal;
using OopExercise.Entity;
using OopExercise.ExtentionMethod;
using OopExercise.Helper;

namespace OopExercise.Menu
{
	public class MainMenu
	{
		public static void Show()
		{
            DalProduct pro = new();
           
            while (true)
            {
                Console.WriteLine("chon so 1 de them sinh vien");
                Console.WriteLine("chon so 2 de xem so luong sinh vien");
                Console.WriteLine("chon so 3 de xoa sinh vien");
                Console.WriteLine("chon so 4 de tim kiem sinh vien");
                Console.WriteLine("chon so 5 de sua thong tin sinh vien");
                Console.WriteLine("chon so 6 de xap xep thong tin sinh vien giam dan");
                Console.WriteLine("chon so khac de thoat");
                Console.WriteLine("vui long chon : ");
                int chosse = Validate<int>.Input("please chosse:");
                switch (chosse)
                {
                    case 1:pro.ChangeColor(ConsoleColor.White, ConsoleColor.Red);
                            pro.Add(); break;
                    case 2: pro.Add(); break;
                    case 3: pro.Add(); break;
                    case 4: pro.Add(); break;
                    case 5: pro.Add(); break;
                    case 6: pro.Add(); break;
                    default: Console.WriteLine("Exit"); return;
                }
            }
        }
	}
}


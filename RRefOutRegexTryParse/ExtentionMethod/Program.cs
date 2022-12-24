using ExtentionMethod;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("voi long nhap vao gia tri cho bien i:");
        int i = int.TryParse(Console.ReadLine(), out int resual) ? resual : 0;
        CheckNumber.CheckIsGreaterThan(i, 100);
        i.CheckIsGreaterThan(100);
        Program pro = new Program();
        pro.Hello();
    }
}

global using RefOutRegexTryParse;

int a = 10;
int b = 5;

//RefOut.ChangeVar(ref a, ref b);
//RefOut.ChangeVar(out int a, out int b);
Console.WriteLine("main: ");
Console.WriteLine($"{nameof(a)}={a}, {nameof(b)}={b}");
//pure oop = oop nguyen thuy, thuan oop = > c# cu
//RegexTryParse parse = new RegexTryParse();

//dung tu vqr
//var par = new RegexTryParse();
//target-type c# new
RegexTryParse P = new();
//P.CheckNumberByRegex();
//P.CheckStringByTryParse();
//P.TryCatchBug();

Human h = new();
h.Show();

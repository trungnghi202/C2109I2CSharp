global using System;
namespace RefOutRegexTryParse
{
    internal class RefOut
	{
        public static void ChangeVar(int a, int b)
        {
            var tam = a;
            a = b;
            b = tam;
        }
    }
}


// https://www.bestprog.net/ru/2018/08/25/example-of-creating-a-unit-test-in-ms-visual-studio-2017-c_ru/
using System;


namespace min_app
{
    public class Program
    {
        public static int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Demo of Unit-testing in C#");
            Console.ReadKey();
        }
    }
}

using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
			int a = 1;
			int b = 2;
			int c = a + b;
            Console.WriteLine("Hello World!");
			Console.WriteLine("The current day and time is " + DateTime.Now);
			Console.WriteLine(c);
        }
    }
}

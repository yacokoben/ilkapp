using System;

namespace ysnconsole2
{
    class Program
    {
        static int Mymethod(int x ,int y)
        {
            return 5 + x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Mymethod(3,2));
        }
    }
}

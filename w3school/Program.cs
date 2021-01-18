using System;

namespace w3school
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Products();
            Console.WriteLine(pro[1]);

        }
    }
    class Products
    {
        public Products()
        {
            Urun = { "laptop","netbook"};
        }
    }
}

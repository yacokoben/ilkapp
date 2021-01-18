using System;

namespace ysnconsole
{
    class Program
    {
        static void Mymethod(string Ad , string SAd)
        {
            Console.WriteLine("MERHABA " + Ad + " " + SAd + " HOŞGELDİNİZ");
        }

        static void islem(int ilksayi , int ikincisayi)
        {
            int toplam = ilksayi + ikincisayi;
            Console.WriteLine(ilksayi + " + " + ikincisayi + " = " + toplam);
        }
        static void Main(string[] args)
        {
            Mymethod("Yasin", "Yeşilay");
            islem(15, 16);
            
        }
    }
}

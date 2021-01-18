using System;

namespace ilkapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategori = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 19.68;
            bool girisOnayi = true;
            double dolarbugun = 19.65;
            double dolardun = 19.46;

            if (girisOnayi == true)
            {
                Console.WriteLine("Sisteme giriş yapıldı");
                Console.WriteLine(kategori);
                Console.WriteLine(ogrenciSayisi);
                Console.WriteLine(faizOrani);

            }
            else
            {
                Console.WriteLine("Sisteme Çıkış Yapıldı");
            }

            if (dolarbugun > dolardun)
            {
                Console.WriteLine("Dolar Artış Eğliminde");
            }
            else if (dolarbugun == dolardun)
            {
                Console.WriteLine("Dolar Kuru Sabit");
            }
            else
            {
                Console.WriteLine("Dolar Azalış Eğliminde");

            }
        }
    }

	}
    


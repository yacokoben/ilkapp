using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 85;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            //Ürün arrayi oluşturmak
            Product[] Urunler = new Product[] {urun1,urun2};

            foreach (Product uruntakmadi in Urunler)
            {
                Console.WriteLine(uruntakmadi.Adi);
                Console.WriteLine(uruntakmadi.Fiyati);
                Console.WriteLine(uruntakmadi.Aciklama);
                Console.WriteLine("----------------");
            }

            

            Console.WriteLine("---------------Methodlar------------");
            // ilk önce class ın bir tane yedeğini oluşturum new ile sonrasında classın içerisindeki methodu çağırıyoruz.
            // ekle parametre oluşturup classa gönderdik
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","yeşil armut",15);
            sepetManager.Ekle2("kamkat", "yeşil kamkat", 15);
            sepetManager.Ekle2("Atkestanesi", "yeşil at kestanesi", 15);
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        class urunler
        {
            static void Main(string[] args)
            {
                string[] urunler = { "Laptop", "Mouse", "Klavye", "Kulaklık" };

                
                Console.WriteLine("For döngüsü ile hazırlandı");
                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine(urunler[i]);
                }
                // foreach döngüsü ile
                Console.WriteLine("For each döngüsü ile hazırlandı");
                foreach (var urun in urunler)
                {
                    
                    Console.WriteLine(urun);
                }
                // while döngüsü ile
                Console.WriteLine("while döngüsü ile hazırlandı");
                int sayac = 0;
                while (sayac < urunler.Length)
                {
                    
                    Console.WriteLine(urunler[sayac]);
                    sayac++;
                }
            }

        }
        
    }
}

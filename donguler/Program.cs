using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "1.kurs", "2.kurs","3.kurs" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For each döngüsü başlıyor");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}

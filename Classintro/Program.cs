using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmeni = "Yasin";
            kurs2.izlenmeOrani = 45;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmeni = "Kerem";
            kurs3.izlenmeOrani = 98;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmeni = "Murat";
            kurs4.izlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmeni + " " + kurs1.izlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmeni + " " + kurs2.izlenmeOrani);
            //Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmeni + " " + kurs3.izlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " adlı kursumumuzu " + kurs.Egitmeni + " vermektedir. ");
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int izlenmeOrani { get; set; }
    }
}

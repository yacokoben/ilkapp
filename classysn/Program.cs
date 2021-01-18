using System;

namespace classysn
{
    class Progra
    {
        class AraBa
        {
            string model;
            string rengi;
            int yili;


            static void Main(string[] args)
            {
                AraBa Ford = new AraBa();
                Ford.model = "Mustang";
                Ford.rengi = "red";
                Ford.yili = 2015;

                AraBa Opel = new AraBa();
                Opel.model = "insingia";
                Opel.rengi = "mor";
                Opel.yili = 1865;

                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.yili);

            }
        }
        
    }
}

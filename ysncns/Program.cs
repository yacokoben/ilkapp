using System;

namespace ysncns
{
    class Program
    {
        class Car
        {
            public string model;
            public string color;
            public int year;


            public Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }
            static void Main(string[] args)
            {
                Car Ford = new Car("Mustang", "Red", 1986);

                
            }
        }

    }
        
}

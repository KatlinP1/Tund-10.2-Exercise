using System;

namespace auto
{
    class Car
    {
        public string model;
        public string mark;
        public string color;
        public string regNumber;
        public int odo=0;

        public void Drive()
        {
            odo += 100;
        }
        
        public void ShowOdo()
        {
            Console.WriteLine($"The car {model} {mark} {regNumber} odometer count is {odo}");
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar= new Car();
            myCar.model = "Superb";
            myCar.mark = "Skoda";
            myCar.regNumber = "123ABC";
            myCar.odo = 400;

            for (int i = 0; i < 10; i++)
            {
                myCar.Drive();
            }
            
            myCar.ShowOdo();



        }
    }
}
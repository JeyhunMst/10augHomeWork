using _10AugHomeWork.Models;
using System;

namespace _10AugHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {           
            Car CarNumber1 = new Car(1999,"Silver","Nissan", "Skyline R34", 65 , 0.16 , 60);
            Console.WriteLine( CarNumber1.Drive(200) );
            CarNumber1.ShowInfo();
            Car CarNumber2 = new Car(1989,"Black","Mazda","Rx7 FC Turbo", 90 , 0.16 , 70);
            Console.WriteLine(CarNumber2.Drive(300));
            CarNumber2.ShowInfo();
            Car CarNumber3 = new Car(1990, "Red", "Corvette", "Coupe C4", 76 , 0.11);
            CarNumber3.ShowInfo();
        }
    }
}

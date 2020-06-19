using System;

namespace inheritance_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle whips = new Vehicle();
            Car rides = new Car();
            Motorbike bikes = new Motorbike(4, "Ducatti", true, 500);
            Console.WriteLine(bikes.doors + " " + bikes.brand + " " + bikes.handlebars + " " + bikes.cc);
            //whips.beep();
            //rides.beep();
            //rides.boot = true;
            //rides.color = "rebeccapurple";
            //rides.doors = 4;
            //rides.wowFactor = true;
            //rides.insurance = true;
            //rides.tax = true;
            //bikes.wheels = 2;
            //bikes.brand = "Ducatti";
            //Console.WriteLine(rides.boot);
            //Console.WriteLine(rides.color);
            //Console.WriteLine(rides.doors);
            //Console.WriteLine(rides.wowFactor);
            //Console.WriteLine(bikes.wheels);
            //Console.WriteLine(bikes.brand);

        }
    }
}

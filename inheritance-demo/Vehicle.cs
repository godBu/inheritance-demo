using System;
namespace inheritance_demo
{
    public class Vehicle // base class / parent class
    {
        public int doors;
        public double hP;
        public string color;
        public string regPlate;
        public bool wowFactor;
        public bool insurance;
        public bool tax;
        public int wheels;

        public void beep()
        {
            Console.WriteLine("Beep");
            Console.Beep();
        }
    }

    public class Car : Vehicle // child class / derived class
    {
        public string brand;
        public string model;
        public bool boot;
    }

    // here...

    public class Motorbike : Vehicle
    {
        public string brand;
        public bool handlebars;
        public double cc;

        public Motorbike(int Doors, string Brand, bool Handlebars, double CC)
        {
            doors = Doors;
            brand = Brand;
            handlebars = Handlebars;
            cc = CC;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace S_Sharp
{
    abstract class Car : IHasInfo, ICar
    {
        public abstract int Speed { get; }
        public abstract void Drive();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Speed: {Speed}");
        }
    }
    class BMW : Car
    {
        public override int Speed { get { return 70; } }
        public override void Drive()
        {
            Console.WriteLine("Карыто");
        }
    }
    class Niva : Car
    {
        public override int Speed { get { return 60; } }
        public override void Drive()
        {
            Console.WriteLine("Машина мечты");
        }
    }

    class Driver
    {
        public void Drive(Car driver)
        {
            driver.Drive();
        }
        public void ChekInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }
}

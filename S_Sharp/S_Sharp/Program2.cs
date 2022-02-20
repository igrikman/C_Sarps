using System;
using System.Collections.Generic;
using System.Text;

namespace Program2
{
    public class PlayerCar
    {
        public void Car(Multipleyer multipleyer)
        {
            multipleyer.Collor();
            multipleyer.Car();
        }
        public void ShowInfo(Multipleyer multipleyer)
        {
            multipleyer.GetInfo();
        }
    }
    public abstract class Multipleyer
    {
        public abstract void Collor();
        public abstract void Car();
        public abstract int speed { get; }
        public void GetInfo()
        {
            Console.WriteLine(GetType().Name, $"скорось {speed} км/ч");
        }
    }
    public class Red : Multipleyer
    {
        public override void Collor()
        {
            Console.WriteLine("Красный");
        }
        public override void Car()
        {
            Console.WriteLine("Мусоровоз");
        }
        public override int speed { get { return 10; } }
    }
    public class Blue : Multipleyer
    {
        public override void Collor()
        {
            Console.WriteLine("Синий");
        }
        public override void Car()
        {
            Console.WriteLine("Нива");
        }
        public override int speed { get { return 11; } }
    }
}

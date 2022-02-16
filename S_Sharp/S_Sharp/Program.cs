using System;

namespace C_Sharp
{
    //Инкапсуляция
    public class Gun
    {
        public bool amo = false;
        private void Reloud()
        {
            Console.WriteLine("Я пустой");
            Console.WriteLine("Перезарезаю");
            amo = true;
        }
        public void Sooht()
        {
            while (amo == false)
            {
                Reloud();
                continue;
            }
            Console.WriteLine("Выстрел");
            amo = false;
        }
    }
    //END

    //Наследование и Полифорфизм
    public class AutoGun : Gun
    {
        new public bool amo = false;
        private void Reloud()
        {
            Console.WriteLine("Я пустой");
            Console.WriteLine("Перезарезаю");
            amo = true;
        }
       new public void Sooht()
        {
            for (int i = 1; i < 6; i++)
            {
                while (amo == false)
                {
                    Reloud();
                    continue;
                }
                Console.WriteLine($"{i} Выстрел");
                
                amo = false;
            }
        }
    }
    //END
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Sooht();
            AutoGun gunAuto = new AutoGun();
            gunAuto.Sooht();
        }
    }
}
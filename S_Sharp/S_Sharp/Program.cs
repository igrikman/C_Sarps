using System;

namespace C_Sharp
{
    //1. Инкапсуляция
    public class Gun
    {
        private bool amo = false;
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

    //2. Наследование и Полифорфизм
    public class AutoGun : Gun
    {
       private bool amo = false;
       private void Reloud()
        {
            Console.WriteLine("Я пустой");
            Console.WriteLine("Перезарежаю");
            amo = true;
        }
       public new void Sooht()
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

    //3. Модификаторы доступа
    public class MP_40
    {
        private protected int speed = 300;
        protected int amo = 30;
        internal string material = "steel";
        public void Shoot_MP()
        {
            int sh_sec = speed / amo;
            Console.WriteLine($"Выстрел/сек {sh_sec} Материал {material}");
        }
    }
    public class AK : MP_40
    {
       private protected new int speed = 600;
       protected internal new int amo = 30;
       internal new string material = "wood & steel";
        public void Shoot_AK()
        {
            int sh_sec = speed / amo;
            Console.WriteLine($"Выстрел/сек {sh_sec} Материал {material}");
        }
    }
    //Циклы

    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("_");

            Gun gun = new Gun();
            gun.Sooht();
            //2.
            Console.WriteLine("_");

            AutoGun gunAuto = new AutoGun();
            gunAuto.Sooht();
            //3.
            Console.WriteLine("_");
            MP_40 mp = new MP_40();
            mp.material = "iron";
            mp.Shoot_MP();

            AK ak = new AK();
            ak.amo = 45;
            ak.material = "Polimer & steel";
            ak.Shoot_AK();
            

        }
    }
}
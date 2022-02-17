using System.Collections;
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
    //END

    //4.Циклы
    public class Cikle
    {
        protected string[] mas = { "l", "u", "c", "k" };
        private int j = 1;
        private int k = 3;
        private int m = 5;
        public void aFor()
        {
            for (int i = j; i < 5; i++)
            {
                Console.WriteLine($"for {i}");
            }
            aDoWhile();
        }
        public void aDoWhile()
        {
            do
            {
                Console.WriteLine($"Do...While {k}");
                k--;
            }
            while (k > 0);
            aWhile();
        }
        public void aWhile()
        {
            while (m == 5)
            {
                Console.WriteLine($"While {m}");
                m--;
            }
            aForeach();

        }
        public void aForeach()
        {
            foreach (string s in mas)
            {
                Console.WriteLine($"Foreach {s}");
            }
        }

    }
    //END

    //4.1Enumerable
    class Week : IEnumerable
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator() => days.GetEnumerator();
    }
    //END

    //5.Operator
    class Operator
    {
        public int a =45 ;
        private int b = 45;
        private int c = -45;
        public void Oper()
        {
            if(a<50)
            {
                int z = a + b;
                Console.WriteLine(z);
            }
            else if (a<-1)
            {
                int z = a + c;
                Console.WriteLine(z);
            }
            else
            {
                switch (a)
                {
                    case (60):
                        Console.WriteLine("a = 60");
                        break;
                    case (70):
                        Console.WriteLine("a = 70");
                        break;
                    default:
                        Console.WriteLine("Не повезло");
                        break;
                }

            }
        }

    }
    //END
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

            //4.
            Console.WriteLine("_");

            Cikle cikle = new Cikle();
            cikle.aFor();
            Week week = new Week();
            foreach(var day in week)
            {
                Console.WriteLine(day);
            }

            //5.
            Console.WriteLine("_");

            Operator oper = new Operator();
            oper.Oper();
            oper.a = -100;
            oper.Oper();
            oper.a = 100;
            oper.Oper();

        }
    }
}
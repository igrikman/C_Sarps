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
    //end

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
        private readonly int j = 1;
        private int k = 3;
        private int m = 5;
        public void Afor()
        {
            for (int i = j; i < 5; i++)
            {
                Console.WriteLine($"for {i}");
            }
            AdoWhile();
        }
        public void AdoWhile()
        {
            do
            {
                Console.WriteLine($"Do...While {k}");
                k--;
            }
            while (k > 0);
            Awhile();
        }
        public void Awhile()
        {
            while (m == 5)
            {
                Console.WriteLine($"While {m}");
                m--;
            }
            Aforeach();

        }
        public void Aforeach()
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
        private readonly string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                         "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator() => days.GetEnumerator();
    }
    //END

    //5.Operator
    class Operator
    {
        public int a = 45;
        private readonly int b = 45;
        private readonly int c = -45;
        public void Oper()
        {
            if (a < 50)
            {
                int z = a + b;
                Console.WriteLine(z);
            }
            else if (a < -1)
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

    //6.METOD
    class Metod
    {
        public void Message(string message = "No message")
        {
            Console.WriteLine(message);

            string messag = GetMessage();
            Console.WriteLine(messag);
        }
        public void Sum(int a, int b)
        {
            int res = a + b;
            Console.WriteLine($"{a}+{b}={res}");
            int num = GetNumber();
            Console.WriteLine($"Call me now {num}");
        }
        public void Person(string name, int age, string work = "undefined")
        {
            Console.WriteLine($"Name = {name}; Age = {age};Work = {work};");
        }
        public string GetMessage()
        {
            return "Bay";
        }
        public int GetNumber()
        {
            return 445827429;
        }

        public int number = 5;
        public void Numb()
        {
            void Nb(ref int n)
            {
                n++;
                Console.WriteLine($"Число {n}");
            }
            Nb(ref number);

        }
        public void SumNumb()
        {
            void Sim(int x, int y, out int result)
            {
                result = x + y;

            }
            int n;
            Sim(1, 2, out n);
            Console.WriteLine($"число {n}");
        }
    }
    //END.

    //7.Property 
    class GS
    {
        private int x;
        public int X
        {
            get { return x; }
            set
            {
                if (value < 1)
                {
                    x = 1;
                    return;
                }
                if (value > 10)
                {
                    x = 10;
                    return;
                }
                x = value;
            }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                if (value < 1)
                {
                    y = 1;
                    return;
                }
                if (value > 10)
                {
                    y = 10;
                    return;
                }
                y = value;
            }
        }

        public int Z { get; set; }
        public void Sum()
        {
            int result = x + y + Z;
            Console.WriteLine($"сумма x + y + Z = {result}");
        }
    }
    //End

    //8.Virtual & Abstract

    class Person
    {
        public void Work(OldWork oldWork)
        {
            oldWork.Profession();
        }
    }
    public class OldWork
    {
        protected virtual void No()
        {
            Console.WriteLine("Но пока электрик");
        }
        public virtual void Profession()
        {
            Console.WriteLine("Я не хочу быть электриком");
            No();
        }
    }
    class NewWork : OldWork
    {

        public override void Profession()
        {
            Console.WriteLine("Я буду програмистом");
            No();
        }
    }

    public abstract class Enemy
    {
        public abstract int damage { get; }
        public abstract void Punch();
        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }
    class Snork : Enemy
    {
        public override int damage { get { return 10; } }
        public override void Punch()
        {
            Console.WriteLine($"Делает - Ааауээ и наносит {damage} урона");
        }
    }
    class Krovosos : Enemy
    {
        public override int damage { get { return 15; } }
        public override void Punch()
        {
            Console.WriteLine($"Делает - Л ьзззз и наносит {damage} урона"); 
        }
    }
    class Tyshkan : Enemy
    {
        public override int damage { get { return 2; } }
        public override void Punch()
        {
            Console.WriteLine($"Делает - Грызь и наносит {damage} урона");
        }
    }
    public class Player
    {
        public void Hp(Enemy enemy)
        {
            enemy.Punch();
        }
        public void ChekInfo(Enemy enemy)
        {
            enemy.ShowInfo();
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
            cikle.Afor();
            Week week = new Week();
            foreach (var day in week)
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

            //6.
            Console.WriteLine("_");

            Metod metd = new Metod();
            metd.Message("Hello");
            metd.Sum(25, 25);
            metd.Person("Igor", 23);
            metd.Numb();
            metd.number = 9;
            metd.Numb();
            metd.SumNumb();

            //7.
            Console.WriteLine("_");

            GS gs = new GS();
            gs.X = 4;
            gs.Y = 6;
            gs.Z = 10;
            gs.Sum();

            //8.
            Console.WriteLine("_");

            OldWork old = new OldWork();
            NewWork nWork = new NewWork();
            Person person = new Person();
            person.Work(old);
            person.Work(nWork);
            Console.WriteLine("_");
            Player player = new Player();
            Enemy[] enemys = { new Snork(), new Krovosos(), new Tyshkan() };
            foreach (var enemy in enemys)
            {
                player.ChekInfo(enemy);
                player.Hp(enemy);
            }

        }
    }
}

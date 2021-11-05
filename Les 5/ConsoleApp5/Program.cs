using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Player fpsplayer = new Player(420);

            Money money = new Money(10);

            HealPotion healPotion = new HealPotion(30);

            Console.WriteLine("De speler heeft money: " + fpsplayer.pMoney);
            Console.WriteLine("De speler heeft levens: " + fpsplayer.pHealth);
        }

        public class Player
        {
            private int startingHealth;

            public int pMoney = 0;
            public int pHealth = 0;

            public Player(int startingHealth)
            {
                this.startingHealth = startingHealth;
                pHealth = startingHealth;
            }

            public void AddMoney(int amount)
            {
                pMoney += amount;
            }

            public void AddHealth(int amount)
            {
                pHealth += amount;
                if (pHealth > startingHealth) pHealth = startingHealth;
            }
        }

        public abstract class Equipment
        {
            public virtual void Equip()
            {
                Console.WriteLine("Item equipped");
            }
        }


        public class Armor : Equipment
        {
            public override void Equip()
            {
                base.Equip();
            }
        }

        public class Weapon : Equipment
        {
            public override void Equip()
            {
                base.Equip();
            }
        }

        public class Money
        {
            public int pMoney;

            public Money(int money)
            {
                this.pMoney = money;
            }
        }

        public class HealPotion
        {
            public int heal;

            public HealPotion(int heal)
            {
                this.heal = heal;
            }
        }
    }
}
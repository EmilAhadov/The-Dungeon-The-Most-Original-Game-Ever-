using System;

namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            CharactherCreateMenu();
        }
        static void CharactherCreateMenu()
        {
            Console.WriteLine("Please Chose your class: \n" +
                "1.Assasin\n" +
                "2.Barbarian\n" +
                "3.Knight\n");
            string playerClass = Console.ReadLine();
            if (playerClass == "1")
            {
                AssasinClass();
            }
            else if (playerClass == "2")
            {
                BarbarianClass();
            }
            else if (playerClass == "3")
            {
                KnightClass();
            }
        }
        static void AssasinClass()
        {
            Player assasin = new Assasin();
            Console.WriteLine("Choose your weapon\n" +
                "1.Double Dagger\n" +
                "2.Twin Side Spear");
            string playerWeapon = Console.ReadLine();
            if (playerWeapon == "1")
            {
                Weapon doubleDagger = new DoubleDagger();
            }
            else if (playerWeapon == "2")
            {
                Weapon twinSideSpear = new Twin_Side_Spear();
            }
        }
        static void BarbarianClass()
        {
            Player barbarian = new Barbarian();
            Console.WriteLine("Choose your weapon\n" +
                "1.Double Axe\n" +
                "2.Wooden Mace");
            string playerWeapon = Console.ReadLine();
            if (playerWeapon == "1")
            {
                Weapon doubleAxe = new DoubleAxe();
            }
            else if (playerWeapon == "2")
            {
                Weapon woodenMace = new WoodenMace();
            }
        }
        static void KnightClass()
        {
            Player knight = new Knight();
            Console.WriteLine("Choose your weapon\n" +
                "1.Steel Mace\n" +
                "2.Long Sword");
            string playerWeapon = Console.ReadLine();
            if (playerWeapon == "1")
            {
                Weapon steelMace = new SteelMace();
            }
            else if (playerWeapon == "2")
            {
                Weapon longSword = new LongSword();
            }
        }
    }
}

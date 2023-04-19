using System;

namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Console.WriteLine(dice.DiceReturn());



            var (player, weapon) = CharactherCreateMenu();
            Game game = new Game(player, weapon);
            game.Level1();

        }
        #region CharactherCreateMenu
        static (Player,Weapon) CharactherCreateMenu()
        {
            Player player = null;
            Weapon weapon= null;
            do
            {
                Console.WriteLine("Please Chose your class: \n" +
                "1.Assasin\n" +
                "2.Barbarian\n" +
                "3.Knight\n");
                string playerClass = Console.ReadLine();
                if (playerClass == "1")
                {
                    player = new Assasin();
                    weapon = AssasinClass();
                }
                else if (playerClass == "2")
                {
                    player = new Barbarian();
                    weapon = BarbarianClass();
                }
                else if (playerClass == "3")
                {
                    player = new Knight();
                    weapon = KnightClass();
                }
                else
                {
                    Console.WriteLine("Wrong choice try again");
                }

            } while (player == null);
            return (player,weapon);
        }
        static Weapon AssasinClass()
        {
            Weapon assasinWeapon= null;
            do
            {
                Console.WriteLine("Choose your weapon\n" +
                "1.Double Dagger\n" +
                "2.Twin Side Spear");
                string playerWeapon = Console.ReadLine();
                if (playerWeapon == "1")
                {
                    assasinWeapon = new DoubleDagger();
                }
                else if (playerWeapon == "2")
                {
                    assasinWeapon = new Twin_Side_Spear();
                }
                else
                {
                    Console.WriteLine("Wrong choice try again");
                }
            } while (assasinWeapon == null);
            return assasinWeapon;
        }
        static Weapon BarbarianClass()
        {
            Weapon barbarianWeapon = null;
            do
            {
                Console.WriteLine("Choose your weapon\n" +
                                    "1.Double Axe\n" +
                                    "2.Wooden Mace");
                string playerWeapon = Console.ReadLine();
                if (playerWeapon == "1")
                {
                    barbarianWeapon = new DoubleAxe();
                }
                else if (playerWeapon == "2")
                {
                    barbarianWeapon = new WoodenMace();
                }
                else
                {
                    Console.WriteLine("Wrong choice try again");
                }
            } while (barbarianWeapon == null);
            return barbarianWeapon;
        }
        static Weapon KnightClass()
        {
            Weapon knightWeapon = null;

            do
            {
                Console.WriteLine("Choose your weapon\n" +
                "1.Steel Mace\n" +
                "2.Long Sword");
                string playerWeapon = Console.ReadLine();
                if (playerWeapon == "1")
                {
                    knightWeapon = new SteelMace();
                }
                else if (playerWeapon == "2")
                {
                    knightWeapon = new LongSword();
                }
                else
                {
                    Console.WriteLine("Wrong choice try again");
                }

            } while (knightWeapon == null);
            return knightWeapon;
        }

#endregion



    }
}

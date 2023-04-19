using System;
using System.Collections.Generic;

namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {

        class Game
        {
            public Player _Player { get; set; }
            public  Weapon _Weapon { get; set; }
            public Game(Player player, Weapon weapon)
            {
                _Player = player;
                _Weapon = weapon;

            }

            public void Level1()
            {
                List<Enemy> enemies = new List<Enemy>();
                MeatWall meatWall = new MeatWall();
                enemies.Add(meatWall);
                bool test = true;
                int turn = 0;
                do
                {
                    turn++;
                    if (turn % 2 == 0)
                    {
                        _Player.TakeDamage(1);
                        if (_Player.CreatureDie(_Player))
                        {
                            Console.WriteLine("Player Die");
                            test = false;
                        }
                    }
                    else
                    {
                        meatWall.TakeDamage(50000);
                        if(meatWall.CreatureDie(meatWall))
                        {
                            Console.WriteLine("Enemy Die");
                            test = false;
                        }
                    }
                } while (test);
            }
            static void Level2()
            {

            }
            static void Level3()
            {

            }
        }
    }
}

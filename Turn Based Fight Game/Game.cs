using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {

        class Game
        {
            public Player _Player { get; set; }
            public Weapon _Weapon { get; set; }
            public Game(Player player, Weapon weapon)
            {
                _Player = player;
                _Weapon = weapon;
            }
            public void Play()
            {
                List<Enemy> enemies = new List<Enemy>();
                MeatWall meatWall = new MeatWall();
                bool test = true;
                int turn = 0;

                do
                {
                } while (test);
            }
        }
    }
}

﻿namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {
        class Player : Creature
        {
            protected Player(int health, int armor, int weight) : base(health, armor, weight) { }
        }

        //-------------------------------------------------------------------------------------------
        //Public must convert to protected
        class Assasin : Player
        {
            public Assasin() : base(100, 50, 60) { }
        }

        class Barbarian : Player
        {
            public Barbarian() : base(400, 0, 110) { }
        }

        class Knight : Player
        {
            public Knight() : base(200, 75, 150) { }
        }
    }
}


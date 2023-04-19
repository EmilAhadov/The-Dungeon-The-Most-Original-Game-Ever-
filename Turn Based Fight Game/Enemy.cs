namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {
        class Enemy : Creature
        {
            public Enemy(int health, int armor, int weight) : base(health, armor, weight) { }
        }
        class MeatWall : Enemy
        {
            public MeatWall() : base(1000000000, 0, 0) { }

        }
        class Goblin : Enemy
        {
            public Goblin() : base(20,5,45) { }
        }
        class Orc : Enemy
        {
            public Orc() : base(40, 20, 60) { }
        }
    }
}


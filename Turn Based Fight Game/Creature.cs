using Elasticsearch.Net;

namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {
        class Creature
        {
            protected int _health;
            protected int _armor;
            protected int _weight;

            public Creature(int health, int armor, int weight)
            {
                _health = health;
                _armor = armor;
                _weight = weight;
            }
            void TakeDamage(int damage)
            {
                _health -= damage;
            }
        }
    }
}


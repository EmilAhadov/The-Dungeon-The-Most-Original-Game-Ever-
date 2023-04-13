namespace Solid
{
    internal partial class Program
    {
        abstract class Chracter
        {
            public int _health { get; set; }
            public int _damage { get; set; }

            public Chracter(int health,int damage)
            {
                _health = health;
                _damage = damage;

            }
            
            public abstract int TakeDamage(int damage);


        }
        class Player : Chracter
        {
            public Player() : base(60,5)
            {
            }

            public override int TakeDamage(int damage)
            {
                _health -= damage;
                return _health;
            }
        }
        class Enemy : Chracter
        {
            public Enemy() : base(40,4)
            {
            }

            public override int TakeDamage(int damage)
            {
                _health -= damage;
                return _health;
            }
        }

    }
}

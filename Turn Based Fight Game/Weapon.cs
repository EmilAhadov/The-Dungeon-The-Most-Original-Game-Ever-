namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {
        class Weapon
        {
            protected int _damage;
            protected int _weaponWeight;
            public Weapon(int damage, int weaponWeight)
            {
                _damage = damage;
                _weaponWeight = weaponWeight;
            }

        }
        class DoubleDagger : Weapon
        {
            public DoubleDagger() : base(30,10) { }
        }
        class Twin_Side_Spear : Weapon
        {
            public Twin_Side_Spear() : base(30, 10) { }
        }
        class DoubleAxe : Weapon
        {
            public DoubleAxe() : base(30, 10) { }
        }
        class WoodenMace : Weapon
        {
            public WoodenMace() : base(30, 10) { }
        }
        class SteelMace : Weapon
        {
            public SteelMace() : base(30, 10) { }
        }
        class LongSword : Weapon
        {
            public LongSword() : base(30, 10) { }
        }
    }
}

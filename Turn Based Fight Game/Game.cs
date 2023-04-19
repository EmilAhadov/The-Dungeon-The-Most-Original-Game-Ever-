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

            static void Level1(Player player, Weapon weapon)
            {

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

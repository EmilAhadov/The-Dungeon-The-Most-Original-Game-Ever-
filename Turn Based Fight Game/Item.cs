using Elasticsearch.Net;

namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {
        class Item
        {

        }
        class EstusFlask : Item
        {
            public int IncreaseHealth(int health)
            {
                return health + 50;
            }
        }
        class PoisonMoss : Item
        {
            public bool DisablePoison()
            {
                return true;
            }
        }
        class Bandage : Item
        {
            public bool DisableBleeding()
            { 
                return true;
            }
        }
    }
}

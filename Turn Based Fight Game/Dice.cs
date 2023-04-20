using System;
namespace Turn_Based_Fight_Game
{
    internal partial class Program
    {
        class Dice
        {
            Random random = new Random();
            public int diceNumber;
            public int DiceReturn()
            {
                diceNumber = random.Next(1,21);
                return diceNumber; 

            }
        }
    }
}

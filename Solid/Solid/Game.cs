using System;

namespace Solid
{
    internal partial class Program
    {
        abstract class Game
        {
            public abstract void Start();
            public abstract bool HasWinner(bool test);
            public abstract int Turn(int turn);
        }

        class Play : Game
        {
            public override void Start()
            {
                Console.WriteLine("Game Begin: ");
            }
            public override bool HasWinner(bool test)
            {
                return test;
            }

            public override int Turn(int turn)
            {
                return turn++;
            }
        }
    }
}

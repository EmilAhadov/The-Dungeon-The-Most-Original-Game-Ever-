using System;

namespace Solid
{
    internal partial class Program
    {
        //---------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            Game game = new Play();
            game.Start();
            int turn = 0;
            Player player= new Player();
            Enemy enemy= new Enemy();
            bool test = game.HasWinner(true);
            do
            {
                turn++;
                if(turn%2 == 0)
                {
                    player.TakeDamage(enemy._damage);
                    if(player._health<=0)
                    {
                        test= false;
                    }
                }
                else
                {
                    enemy.TakeDamage(player._damage);
                    if(enemy._health <= 0 )
                    {
                        test = false;
                    }
                }


            } while (test);
            Console.WriteLine($"Player: {player._health}\n Enemy: {enemy._health}");
        }
        //---------------------------------------------------------------------------------

        //abstract class Game
        //{
        //    public abstract void Play();
        //}
        //class Chess : Game
        //{
        //    public override void Play()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
    }
}

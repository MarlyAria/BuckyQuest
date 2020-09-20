using System.Drawing;
using System;

namespace BuckyQuest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location): base(game, location, 6)
        {
            //no need for subclass constructer
            //baseclass will handle everything
            //the 6 stands for the 6 hitpoints a bat gets when it is created
        }

        public override void Move(Random random)
        {
            /*The bat starts with six hit points.It’ll keep moving toward the
            player and attacking as long as it has one or more hit
            points.When it moves, there’s a 50 % chance that it’ll move
            toward the player, and a 50 % chance that it’ll move in a random
            direction.After the bat moves, it checks if it’s near the player—
            if it is, then it attacks the player with up to two hit points of
            damage.*/
            if (Hitpoints >= 1)
            {
                //eerst uitzoeken of de bat al bij de speler is
                if(Nearby(game.PlayerLocation,1)) //bat is bij speler
                {
                    Random randomDamage = new Random();
                    game.HitPlayer(2, randomDamage); //2 is het max aan damage dat er kan worden toegedient door een bat
                }

                //als de bat niet bij de speler is
                else
                {
                    if (random.Next(2) == 0)
                    {
                        Direction playerDirection = FindPlayerDirection(game.PlayerLocation);
                        base.location = Move(playerDirection, game.Boundaries);
                    }
                    else
                    {
                        Array Directions = Enum.GetValues(typeof(Direction));
                        Direction randomDirection =
                            (Direction)Directions.GetValue(random.Next(Directions.Length));
                        base.location = Move(randomDirection, game.Boundaries);
                    }
                }
            }

        }
    }
}
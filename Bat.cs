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
        }
    }
}
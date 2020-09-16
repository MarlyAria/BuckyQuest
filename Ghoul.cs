using System.Drawing;
using System;

namespace BuckyQuest
{
    internal class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location):base(game, location,10) { }

        public override void Move(Random random)
        {
            /*The ghoul is the toughest enemy.It starts with 10 hit points, and
            only moves and attacks if its hit points are greater than zero.
            When it moves, there’s a two in three chance that it’ll move
            toward the player, and a one in three chance that it’ll stand still.
            If it’s near the player, it attacks the player with up to four hit
            points of damage.*/
        }
    }
}
using System;
using System.Drawing;

namespace BuckyQuest
{
    abstract class Enemy: Mover
    {
        private const int NearPlayerDistance = 25;

        public int Hitpoints { get; private set; }

        public bool Dead
        {
            get
            {
                if (Hitpoints <= 0)
                    return true;
                else
                    return false;
            }
        }

        public Enemy(Game game, Point location, int hitpoints)
            : base(game, location)
        {
            Hitpoints = hitpoints;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            Hitpoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
    }
}
﻿using System;
using System.Drawing;

namespace BuckyQuest
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }

        public Weapon(Game game, Point location) : base (game, location)
        {
            PickedUp = false;
        }

        public void PickedUpWeapon()
        {
            PickedUp = true;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if(Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        private Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            throw new NotImplementedException();
        }

        private bool Nearby(Point location, Point target, int distance)
        {
            throw new NotImplementedException();
        }

       
    }
}
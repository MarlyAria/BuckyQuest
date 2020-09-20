using System;
using System.Drawing;

namespace BuckyQuest
{
    internal class Sword : Weapon
    {
        public Sword(Game game, Point location): base(game, location) { }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
                /*The sword is the first weapon the player picks up. It’s got a wide
                angle of attack: if he attacks up, then it first tries to attack an
                enemy that’s in that direction. If there’s no enemy there, it looks
                in the direction that’s clockwise from the original attack and
                attacks any enemy there. If it still fails to hit, then it attempts to
                attack an enemy counterclockwise from the original direction of
                attack. It’s got a radius of 10, and causes 3 points of damage*/
                
            switch (direction)
            {
                case Direction.Up:
                    if (DamageEnemy(Direction.Up, 10, 3, random) == false)
                    {
                        if (DamageEnemy(Direction.Right, 10, 3, random) == false)
                        {
                            DamageEnemy(Direction.Left, 10, 3, random);
                        }
                    }
                    break;
                case Direction.Right:
                    if (DamageEnemy(Direction.Right, 10, 3, random) == false)
                    {
                        if (DamageEnemy(Direction.Down, 10, 3, random) == false)
                        {
                            DamageEnemy(Direction.Up, 10, 3, random);
                        }
                    }
                    break;
                case Direction.Down:
                    if (DamageEnemy(Direction.Down, 10, 3, random) == false)
                    {
                        if (DamageEnemy(Direction.Left, 10, 3, random) == false)
                        {
                            DamageEnemy(Direction.Right, 10, 3, random);
                        }
                    }
                    break;
                case Direction.Left:
                    if (DamageEnemy(Direction.Left, 10, 3, random) == false)
                    {
                        if (DamageEnemy(Direction.Up, 10, 3, random) == false)
                        {
                            DamageEnemy(Direction.Down, 10, 3, random);
                        }
                    }
                    break;
                default: break;
            }
        }
    }
}
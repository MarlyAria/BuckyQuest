using System;
using System.Drawing;

namespace BuckyQuest
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            switch(direction)
            {
                /*The mace is the most powerful weapon in the dungeon. It doesn’t
                matter in which direction the player attacks with it—since he
                swings it in a full circle, it’ll attack any enemy within a radius of
                20 and cause up to 6 points of damage*/
                case Direction.Up:
                    if (DamageEnemy(Direction.Up, 20, 6, random) == false)
                    {
                        if (DamageEnemy(Direction.Right, 20, 6, random) == false)
                        {
                            if (DamageEnemy(Direction.Left, 20, 6, random) == false)
                            {
                                DamageEnemy(Direction.Down, 20, 6, random);
                            }
                        }
                    }
                    break;
                case Direction.Right:
                    if (DamageEnemy(Direction.Right, 20, 6, random) == false)
                    {
                        if (DamageEnemy(Direction.Down, 20, 6, random) == false)
                        {
                            if (DamageEnemy(Direction.Up, 20, 6, random) == false)
                            {
                                DamageEnemy(Direction.Left, 20, 6, random);
                            }
                        }
                    }
                    break;
                case Direction.Down:
                    if (DamageEnemy(Direction.Down, 20, 6, random) == false)
                    {
                        if (DamageEnemy(Direction.Left, 20, 6, random) == false)
                        {
                            if (DamageEnemy(Direction.Right, 20, 6, random) == false)
                            {
                                DamageEnemy(Direction.Up, 20, 6, random);
                            }
                        }
                    }
                    break;
                case Direction.Left:
                    if (DamageEnemy(Direction.Left, 20, 6, random) == false)
                    {
                        if (DamageEnemy(Direction.Up, 20, 6, random) == false)
                        {
                            if (DamageEnemy(Direction.Down, 20, 6, random) == false)
                            {
                                DamageEnemy(Direction.Right, 20, 6, random);
                            }
                        }
                    }
                    break;
                default: break;
            }
        }
    }
}